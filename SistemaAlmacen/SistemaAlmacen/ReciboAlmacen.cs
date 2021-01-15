using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SistemaAlmacen
{
    public partial class ReciboAlmacen : Form
    {
        public ReciboAlmacen()
        {
            InitializeComponent();

            //Inicializar combo box de Presentacion
            presentacioncbx.SelectedIndex = 0;

            //Cantidad de piezas
            piezastbx.Text = "1";

            SqlConnection OpenCon = new SqlConnection(@"Data Source=WIN-SERVER\JAGUARIRA;Initial Catalog=SistemaAlmacen;Persist Security Info=True;User ID=sa;Password=Jaguar1");

            try
            {
                OpenCon.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string query = "select NombreCliente from ClientesAlmacen";
                SqlDataAdapter da = new SqlDataAdapter(query, OpenCon);
                DataSet ds = new DataSet();
                da.Fill(ds, "ClientesAlmacen");
                clientecbx.DisplayMember = "NombreCliente";
                clientecbx.ValueMember = "NombreCliente";
                clientecbx.DataSource = ds.Tables["ClientesAlmacen"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string jags = formarloteinterno();

            //LOTE INTERNO DEPENDIENDO DEL CLIENTE
            loteinternotbx.Text = jags;

            OpenCon.Close();

            cargarcbxrack();
        }

        public void cargarcbxrack()
        {
            SqlConnection OpenCon = new SqlConnection(@"Data Source=WIN-SERVER\JAGUARIRA;Initial Catalog=SistemaAlmacen;Persist Security Info=True;User ID=sa;Password=Jaguar1");

            try
            {
                OpenCon.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string query = "select NombreRack from Racks";
                SqlDataAdapter da = new SqlDataAdapter(query, OpenCon);
                DataSet ds = new DataSet();
                da.Fill(ds, "Racks");
                Posicioncbx.DisplayMember = "NombreRack";
                Posicioncbx.ValueMember = "NombreRack";
                Posicioncbx.DataSource = ds.Tables["Racks"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OpenCon.Close();
        }

        public string formarloteinterno()
        {
            SqlConnection OpenCon = new SqlConnection(@"Data Source=WIN-SERVER\JAGUARIRA;Initial Catalog=SistemaAlmacen;Persist Security Info=True;User ID=sa;Password=Jaguar1");

            try
            {
                OpenCon.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //CONSULTAR MAYOR CONSECUTIVO DEPENDIENDO DEL CLIENTE
            String consultaconsecliente = "SELECT MAX(IdConseCliente) AS IdConseCliente FROM ReciboAlmacen WHERE Cliente = '" + clientecbx.SelectedValue+"'";

            //CONSULTA OBTENER CLAVE DEL CLIENTE SELECCIONADO
            String consultaclave = "select ClaveCliente from ClientesAlmacen where NombreCliente ='" + clientecbx.SelectedValue + "'";

            //Obtener ultimos dos numeros del año actual
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));
            String yy = datevalue.Year.ToString();
            int startIndex = 2, length = 2;
            String substring = yy.Substring(startIndex, length);
            
            //--------------------------------------
            int MAXCONSE = 0;
            string clavecliente = "";


            try
            {
                //OBTENER CLAVE DEL CLIENTE
                SqlCommand com2 = new SqlCommand(consultaclave, OpenCon);

                if (com2.ExecuteScalar() != DBNull.Value)
                    clavecliente = Convert.ToString(com2.ExecuteScalar());
                else
                    MessageBox.Show("ERROR AL OBTENER LA CLAVE DEL CLIENTE");

                //CONVERTIR CONSULTA MAYOR CONSECUTIVO DEL CLIENTE A INT
                SqlCommand com3 = new SqlCommand(consultaconsecliente, OpenCon);

                if (com3.ExecuteScalar() != DBNull.Value)
                    MAXCONSE = Convert.ToInt32(com3.ExecuteScalar()) + 1;
                else
                    MAXCONSE = 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string LoteInterno = "";

            if(MAXCONSE < 10 && MAXCONSE >= 1)
                LoteInterno = "JAG" + substring + "-" + clavecliente + "000" + MAXCONSE.ToString();

            if (MAXCONSE < 100 && MAXCONSE >= 10)
                LoteInterno = "JAG" + substring + "-" + clavecliente + "00" + MAXCONSE.ToString();

            if (MAXCONSE < 1000 && MAXCONSE >= 100)
                LoteInterno = "JAG" + substring + "-" + clavecliente + "0" + MAXCONSE.ToString();

            if (MAXCONSE < 10000 && MAXCONSE >= 1000)
                LoteInterno = "JAG" + substring + "-" + clavecliente + "" + MAXCONSE.ToString();

            OpenCon.Close();

            return LoteInterno;
        }

        private void cargarbtn_Click(object sender, EventArgs e)
        {
            #region validar datos
            int pesoneto = 0, pesobruto = 0, pzs = 0, largo = 0;
            float espesor = 0, ancho = 0;
            
            if(pesonetotbx.Text != "")
                pesoneto = int.Parse(pesonetotbx.Text);

            if (pesobrutotbx.Text != "")
                pesobruto = int.Parse(pesobrutotbx.Text);

            if (piezastbx.Text != "")
                pzs = int.Parse(piezastbx.Text);

            if(espesortbx.Text != "")
                espesor = float.Parse(espesortbx.Text);

            if (anchotbx.Text != "")
                ancho = float.Parse(anchotbx.Text);

            if (largotbx.Text != "")
                largo = int.Parse(largotbx.Text);

            if(loteinternotbx.Text == "")
            {
                MessageBox.Show("Favor de ingresar el lote interno ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (loteclientetbx.Text == "")
            {
                MessageBox.Show("Favor de ingresar el lote del cliente ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pesonetotbx.Text == "")
            {
                MessageBox.Show("Favor de ingresar el peso neto ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(pesobrutotbx.Text != "" && Convert.ToInt32(pesobrutotbx.Text) < Convert.ToInt32(pesonetotbx.Text))
            {
                MessageBox.Show("El peso neto no puede ser mayor al peso bruto ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            string nombrecaptu = login.VariableSecion;

            SqlConnection OpenCon = new SqlConnection(@"Data Source=WIN-SERVER\JAGUARIRA;Initial Catalog=SistemaAlmacen;Persist Security Info=True;User ID=sa;Password=Jaguar1");
            
            try
            {
                OpenCon.Open();
            }

            catch(Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //CONSULTAR MAYOR ID
            String ConsultaMaxId = "SELECT MAX(Id_almacen) AS Id_almacen FROM ReciboAlmacen";

            //CONSULTAR MAYOR CONSECUTIVO DEPENDIENDO DEL CLIENTE
            String consultaconsecliente = "SELECT MAX(IdConseCliente) AS IdConseCliente FROM ReciboAlmacen WHERE Cliente = '" + clientecbx.SelectedValue +"'";
            
            //Consulta insertar datos recibo almacen
            String insertardatos = "insert into ReciboAlmacen (Id_almacen, LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, FechaRecibo, Observaciones, Cliente, Posicion, IdConseCliente, NombreCapturista, Presentacion, largo) VALUES (@Id_almacen, @LoteInterno, @LoteCliente, @MasterCode, @NumParte, @PesoNeto, @PesoBruto, @Pzs, @Espesor, @Ancho, @Especificacion, @FechaRecibo, @Observaciones, @Cliente, @Posicion, @IdConseCliente, @NombreCapturista, @Presentacion, @largo)";

            //Consulta insertar datos recibo almacen
            String insertdatosinventario = "insert into InventarioAlmacen (Id_almacen, LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, FechaRecibo, Observaciones, Cliente, Posicion, IdConseCliente, NombreCapturista, Presentacion, largo) VALUES (@Id_almacen, @LoteInterno, @LoteCliente, @MasterCode, @NumParte, @PesoNeto, @PesoBruto, @Pzs, @Espesor, @Ancho, @Especificacion, @FechaRecibo, @Observaciones, @Cliente, @Posicion, @IdConseCliente, @NombreCapturista, @Presentacion, @largo)";
   
            try
            {
                //CONVERTIR CONSULTA MAYOR ID A INT
                SqlCommand com = new SqlCommand(ConsultaMaxId, OpenCon);
                int MAXID = 0;

                if (com.ExecuteScalar() != DBNull.Value)
                    MAXID = Convert.ToInt32(com.ExecuteScalar()) + 1;
                else
                    MAXID = 1;

                //CONVERTIR CONSULTA MAYOR CONSECUTIVO DEL CLIENTE A INT
                SqlCommand com3 = new SqlCommand(consultaconsecliente, OpenCon);
                int MAXCONSE = 0;

                if (com3.ExecuteScalar() != DBNull.Value)
                    MAXCONSE = Convert.ToInt32(com3.ExecuteScalar()) + 1;
                else
                    MAXCONSE = 1;
                
                //Insertar datos de recibo de material
                SqlCommand consultainsertardatos = new SqlCommand(insertardatos, OpenCon);
                consultainsertardatos.Parameters.Add("@Id_almacen",SqlDbType.Int).Value = MAXID;
                consultainsertardatos.Parameters.Add("@LoteInterno", SqlDbType.VarChar, 50).Value = loteinternotbx.Text;
                consultainsertardatos.Parameters.Add("@LoteCliente", SqlDbType.VarChar, 50).Value = loteclientetbx.Text;
                consultainsertardatos.Parameters.Add("@MasterCode", SqlDbType.VarChar, 50).Value = mastercodetbx.Text;
                consultainsertardatos.Parameters.Add("@NumParte", SqlDbType.VarChar, 50).Value = numpartetbx.Text;
                consultainsertardatos.Parameters.Add("@PesoNeto", SqlDbType.Int).Value = pesoneto;
                consultainsertardatos.Parameters.Add("@PesoBruto", SqlDbType.Int).Value = pesobruto;
                consultainsertardatos.Parameters.Add("@Pzs", SqlDbType.Int).Value = pzs;
                consultainsertardatos.Parameters.Add("@Espesor", SqlDbType.Float).Value = espesor;
                consultainsertardatos.Parameters.Add("@Ancho", SqlDbType.Float).Value = ancho;
                consultainsertardatos.Parameters.Add("@Especificacion", SqlDbType.VarChar, 50).Value = especificaciontbx.Text;
                consultainsertardatos.Parameters.Add("@FechaRecibo", SqlDbType.Date).Value = dateTimePicker1.Value;
                consultainsertardatos.Parameters.Add("@Observaciones", SqlDbType.VarChar, 50).Value = observacionestbx.Text;
                consultainsertardatos.Parameters.Add("@Cliente", SqlDbType.VarChar, 50).Value = clientecbx.Text;
                consultainsertardatos.Parameters.Add("@Posicion", SqlDbType.VarChar, 50).Value = Posicioncbx.Text;
                consultainsertardatos.Parameters.Add("@IdConseCliente", SqlDbType.Int).Value = MAXCONSE;
                consultainsertardatos.Parameters.Add("@NombreCapturista", SqlDbType.VarChar, 50).Value = nombrecaptu;
                consultainsertardatos.Parameters.Add("@Presentacion", SqlDbType.VarChar, 50).Value = presentacioncbx.Text;
                consultainsertardatos.Parameters.Add("@largo", SqlDbType.Int).Value = largo;
                consultainsertardatos.ExecuteNonQuery();

                //Insertar datos al inventario del almacen
                SqlCommand consultainsertdatosinventario = new SqlCommand(insertdatosinventario, OpenCon);
                consultainsertdatosinventario.Parameters.Add("@Id_almacen", SqlDbType.Int).Value = MAXID;
                consultainsertdatosinventario.Parameters.Add("@LoteInterno", SqlDbType.VarChar, 50).Value = loteinternotbx.Text;
                consultainsertdatosinventario.Parameters.Add("@LoteCliente", SqlDbType.VarChar, 50).Value = loteclientetbx.Text;
                consultainsertdatosinventario.Parameters.Add("@MasterCode", SqlDbType.VarChar, 50).Value = mastercodetbx.Text;
                consultainsertdatosinventario.Parameters.Add("@NumParte", SqlDbType.VarChar, 50).Value = numpartetbx.Text;
                consultainsertdatosinventario.Parameters.Add("@PesoNeto", SqlDbType.Int).Value = pesoneto;
                consultainsertdatosinventario.Parameters.Add("@PesoBruto", SqlDbType.Int).Value = pesobruto;
                consultainsertdatosinventario.Parameters.Add("@Pzs", SqlDbType.Int).Value = pzs;
                consultainsertdatosinventario.Parameters.Add("@Espesor", SqlDbType.Float).Value = espesor;
                consultainsertdatosinventario.Parameters.Add("@Ancho", SqlDbType.Float).Value = ancho;
                consultainsertdatosinventario.Parameters.Add("@Especificacion", SqlDbType.VarChar, 50).Value = especificaciontbx.Text;
                consultainsertdatosinventario.Parameters.Add("@FechaRecibo", SqlDbType.Date).Value = dateTimePicker1.Value;
                consultainsertdatosinventario.Parameters.Add("@Observaciones", SqlDbType.VarChar, 50).Value = observacionestbx.Text;
                consultainsertdatosinventario.Parameters.Add("@Cliente", SqlDbType.VarChar, 50).Value = clientecbx.Text;
                consultainsertdatosinventario.Parameters.Add("@Posicion", SqlDbType.VarChar, 50).Value = Posicioncbx.Text;
                consultainsertdatosinventario.Parameters.Add("@IdConseCliente", SqlDbType.Int).Value = MAXCONSE;
                consultainsertdatosinventario.Parameters.Add("@NombreCapturista", SqlDbType.VarChar, 50).Value = nombrecaptu;
                consultainsertdatosinventario.Parameters.Add("@Presentacion", SqlDbType.VarChar, 50).Value = presentacioncbx.Text;
                consultainsertdatosinventario.Parameters.Add("@largo", SqlDbType.Int).Value = largo;
                consultainsertdatosinventario.ExecuteNonQuery();

                //LIMPIAR VALORES
                loteclientetbx.Text = ""; mastercodetbx.Text = ""; numpartetbx.Text = ""; pesonetotbx.Text = ""; pesobrutotbx.Text = "";
                espesortbx.Text = ""; anchotbx.Text = ""; especificaciontbx.Text = ""; observacionestbx.Text = ""; largotbx.Text = ""; piezastbx.Text = "1";

                //MENSAJE DE EXITO :D
                MessageBox.Show("Recibo capturado correctamente", "GAURDADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            OpenCon.Close();

            string jags = formarloteinterno();

            //LOTE INTERNO DEPENDIENDO DEL CLIENTE
            loteinternotbx.Text = jags;

        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pesonetotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pesobrutotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void espesortbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void anchotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void clientecbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jags = formarloteinterno();

            //LOTE INTERNO DEPENDIENDO DEL CLIENTE
            loteinternotbx.Text = jags;
        }

        private void verrecibobtn_Click(object sender, EventArgs e)
        {
            VerRecibo verrecibo = new VerRecibo();
            verrecibo.ShowDialog();
        }

        private void presentacioncbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(presentacioncbx.Text == "Blanks" )
            {
                largotbx.ReadOnly = false;
                piezastbx.ReadOnly = false;
            }
            else
            {
                largotbx.ReadOnly = true;
                piezastbx.ReadOnly = true;

                largotbx.Text = "";
                piezastbx.Text = "1";
            }
        }

        private void piezastbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void largotbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
