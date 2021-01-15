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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace SistemaAlmacen
{
    public partial class EmbarqueAlmacen : Form
    {
        public EmbarqueAlmacen()
        {
            InitializeComponent();
            cargarcbxcliente();
            llenardatagridinven();
            llenardatagridembar();
        }

        public bool bandera = false;

        public void cargarcbxcliente()
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
                string query = "select NombreCliente from ClientesAlmacen";
                SqlDataAdapter da = new SqlDataAdapter(query, OpenCon);
                DataSet ds = new DataSet();
                da.Fill(ds, "ClientesAlmacen");
                cbxcliente.DisplayMember = "NombreCliente";
                cbxcliente.ValueMember = "NombreCliente";
                cbxcliente.DataSource = ds.Tables["ClientesAlmacen"];
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

        public void llenardatagridinven()
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

            if(lotedelclientetbx.Text == "")
            {
                try
                {
                    var select = "SELECT LoteInterno, LoteCliente, PesoNeto FROM InventarioAlmacen where Cliente = '" + cbxcliente.SelectedValue + "' ORDER BY Id_almacen";
                    var dataAdapter = new SqlDataAdapter(select, OpenCon);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];

                    //alternar color de las filas
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;

                    #region IndiceColums

                    //indice de las columnas
                    dataGridView1.Columns[0].HeaderCell.Value = "Lote Interno";
                    dataGridView1.Columns[1].HeaderCell.Value = "Lote del Cliente";
                    dataGridView1.Columns[2].HeaderCell.Value = "Peso Neto";

                    #endregion

                    //Extender y adaptar datagridview
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var select = "SELECT LoteInterno, LoteCliente, PesoNeto FROM InventarioAlmacen where Cliente = '" + cbxcliente.SelectedValue + "' and LoteCliente = '" + lotedelclientetbx.Text + "' or LoteInterno = '" + lotedelclientetbx.Text + "' ORDER BY Id_almacen";
                    var dataAdapter = new SqlDataAdapter(select, OpenCon);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];

                    //alternar color de las filas
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;

                    #region IndiceColums

                    //indice de las columnas
                    dataGridView1.Columns[0].HeaderCell.Value = "Lote Interno";
                    dataGridView1.Columns[1].HeaderCell.Value = "Lote del Cliente";
                    dataGridView1.Columns[2].HeaderCell.Value = "Peso Neto";

                    #endregion

                    //Extender y adaptar datagridview
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Limpiar textbox lote jag 
            lotejagtbx.Text = "";

            OpenCon.Close();
        }

        public void llenardatagridembar()
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
                var select = "SELECT LoteInterno, LoteCliente, MaterCode, Espesor, Ancho, Pzs, PesoNeto, PesoBruto FROM EmbarqueAlmacen where Cliente = '" + cbxcliente.SelectedValue + "' and Remision = 'JAG-R" + numremisiontbx.Text + "' ORDER BY Id_almacen";
                var dataAdapter = new SqlDataAdapter(select, OpenCon);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView2.ReadOnly = true;
                dataGridView2.DataSource = ds.Tables[0];

                //alternar color de las filas
                dataGridView2.RowsDefaultCellStyle.BackColor = Color.White;
                dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;

                #region IndiceColums

                //indice de las columnas
                dataGridView2.Columns[0].HeaderCell.Value = "Lote Interno";
                dataGridView2.Columns[1].HeaderCell.Value = "Lote del Cliente";
                dataGridView2.Columns[2].HeaderCell.Value = "Master Code";
                dataGridView2.Columns[3].HeaderCell.Value = "Espesor";
                dataGridView2.Columns[4].HeaderCell.Value = "Ancho";
                dataGridView2.Columns[5].HeaderCell.Value = "Piezas";
                dataGridView2.Columns[6].HeaderCell.Value = "Peso Neto";
                dataGridView2.Columns[7].HeaderCell.Value = "Peso Bruto";

                #endregion

                //Extender y adaptar datagridview
                //dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
              
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

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatagridinven();
            llenardatagridembar();
        }

        private void numremisiontbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar que el textbox solo permita numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static string NumRemision = "";

        public static string NombreTransportista = "";

        public static string Destino = "";

        public static string ClienteRem = "";

        public static string FechaRem = "";

        private void cargarrollobtn_Click(object sender, EventArgs e)
        {
            #region validardatos

            if(numremisiontbx.Text == "")
            {
                MessageBox.Show("Favor de ingresar el numero de la remision ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if(lotejagtbx.Text == "")
            {
                MessageBox.Show("Favor de seleccionar un rollo para embarcar ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TxbTrannsportista.Text == "")
            {
                MessageBox.Show("Favor de ingresar los datos del transportista ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TbxDestino.Text == "")
            {
                MessageBox.Show("Favor de ingresar el destino del embarque ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            numremisiontbx.ReadOnly = true;
            cbxcliente.Enabled = false;
            dateTimePicker1.Enabled = false;
            TbxDestino.ReadOnly = true;
            TxbTrannsportista.ReadOnly = true;

            //////////////////

            Destino = TbxDestino.Text;
            NumRemision = numremisiontbx.Text;
            NombreTransportista = TxbTrannsportista.Text;
            ClienteRem = cbxcliente.Text;
            FechaRem = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            //////////////////

            string nombrecaptu = login.VariableSecion;

            #endregion

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

            //Consulta actualizar embarque con el num de remision y fecha de embarque
            String actualizarembarque = "Update EmbarqueAlmacen Set Origen = '" + origentbx.Text + "', Remision = 'JAG-R" + NumRemision + "', Transportista = '" + TxbTrannsportista.Text + "', Capturista = '" + nombrecaptu + "', Destino = '" + TbxDestino.Text + "', FechaEmbarque = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' where LoteInterno = '" + lotejagtbx.Text + "'";

            //Consulta insertar datos recibo almacen
            String insertardatosembarque = "insert into EmbarqueAlmacen (Id_almacen, LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, FechaRecibo, Observaciones, Cliente, Posicion, IdConseCliente, Presentacion, largo) Select Id_almacen, LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, FechaRecibo, Observaciones, Cliente, Posicion, IdConseCliente, Presentacion, largo From InventarioAlmacen where LoteInterno = '" + lotejagtbx.Text + "'";

            //Consulta borrar datos del inventario almacen
            String borrardatosinventario = "Delete From InventarioAlmacen where LoteInterno = '" + lotejagtbx.Text + "'";

            try
            {  
                //Insertar datos de recibo de material
                SqlCommand consultainsertdatosembarque = new SqlCommand(insertardatosembarque, OpenCon);
                consultainsertdatosembarque.ExecuteNonQuery();

                //Borrar datos del inventario del almacen
                SqlCommand consultaborrardatosinventario = new SqlCommand(borrardatosinventario, OpenCon);
                consultaborrardatosinventario.ExecuteNonQuery();

                //Actualizar datos del inventario
                SqlCommand consultaactualizarinventario = new SqlCommand(actualizarembarque, OpenCon);
                consultaactualizarinventario.ExecuteNonQuery();

                //Llenar datagrids
                llenardatagridembar();
                llenardatagridinven();

                //Limpiar textbox lotejagtbx

                lotejagtbx.Text = "";

                //MENSAJE DE EXITO :D
                MessageBox.Show("Rollo movido a embarque correctamente", "Movido con exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = 0;
                i = dataGridView1.CurrentRow.Index;
                lotejagtbx.Text = dataGridView1[0, i].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el rollo, favor de seleccionar un rollo " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LIMPIAR TEXTBOX
                lotejagtbx.Text = "";
            }
        }

        private void cargarbtn_Click(object sender, EventArgs e)
        {
            //validar que se alla generado remision antes de finalizar el embarque
            if (bandera == false)
            {
                MessageBox.Show("No se puede finalizar el embarque sin haber generado antes la remision  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            DialogResult dialogResult = MessageBox.Show("¿Desea finalizar el embarque?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Abilitar textbox numremision, combobox cliente y datetimepicker
                numremisiontbx.ReadOnly = false;
                cbxcliente.Enabled = true;
                dateTimePicker1.Enabled = true;
                TbxDestino.ReadOnly = false;
                TxbTrannsportista.ReadOnly = false;

                //Limpiar valor del combobox cliente
                ClienteRem = "";

                //Limpiar valor del datetime
                FechaRem = "";

                //Limpiar textbox numremision
                numremisiontbx.Text = "";
                NumRemision = "";

                //Limpiar textbox destino
                TbxDestino.Text = "";
                Destino = "";
                
                //Limpiar textbox transportita
                TxbTrannsportista.Text = "";
                NombreTransportista = "";

                //limpiar datagrid de embarque
                llenardatagridembar();
                
                //volver a inicializar la bandera
                bandera = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void regresarrollobtn_Click(object sender, EventArgs e)
        {
            #region validardatos

            if (numremisiontbx.Text == "")
            {
                MessageBox.Show("Favor de ingresar el numero de la remision ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lotejagregresotbx.Text == "")
            {
                MessageBox.Show("Favor de seleccionar un rollo para regresar al inventario ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            numremisiontbx.ReadOnly = true;
            cbxcliente.Enabled = false;
            dateTimePicker1.Enabled = false;

            #endregion

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

            //Consulta insertar datos recibo almacen
            String insertardatosinventario = "insert into InventarioAlmacen (Id_almacen, LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, FechaRecibo, Observaciones, Cliente, Posicion, IdConseCliente, Presentacion, largo) Select Id_almacen, LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, FechaRecibo, Observaciones, Cliente, Posicion, IdConseCliente, Presentacion, largo From EmbarqueAlmacen where LoteInterno = '" + lotejagregresotbx.Text + "'";

            //Consulta borrar datos del inventario almacen
            String borrardatosembarque = "Delete From EmbarqueAlmacen where LoteInterno = '" + lotejagregresotbx.Text + "'";

            try
            {
                //Insertar datos de recibo de material
                SqlCommand consultainsertdatosembarque = new SqlCommand(insertardatosinventario, OpenCon);
                consultainsertdatosembarque.ExecuteNonQuery();

                //Borrar datos del inventario del almacen
                SqlCommand consultaborrardatosinventario = new SqlCommand(borrardatosembarque, OpenCon);
                consultaborrardatosinventario.ExecuteNonQuery();

                //Llenar datagrids
                llenardatagridembar();
                llenardatagridinven();

                //Limpiar textbox lotejagregresotbx
                lotejagregresotbx.Text = "";

                //MENSAJE DE EXITO :D
                MessageBox.Show("Rollo regresado a inventario correctamente", "Movido con exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = 0;
                i = dataGridView2.CurrentRow.Index;
                lotejagregresotbx.Text = dataGridView2[0, i].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el rollo, favor de seleccionar un rollo " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //LIMPIAR TEXTBOX
                lotejagregresotbx.Text = "";
            }
        }

        private void verembarquesbtn_Click(object sender, EventArgs e)
        {
            VerEmbarques verembarques = new VerEmbarques();
            verembarques.ShowDialog();
        }

        public void guardartablaexcel()
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Guardar Archivo en Excel";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Libro de Excel|*.xlsx|Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";

            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    //Cambiar propiedades del Workbook
                    ExcelApp.Columns.ColumnWidth = 20;

                    //Encabezados en las columnas de excel
                    for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    }

                    //llenar tabla
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();

                    //MENSAJE DE EXITO :D
                    MessageBox.Show("Tabla de recibo exportada correctamente", "GAURDADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generarremisionbtn_Click(object sender, EventArgs e)
        {
            RemisionWF remisionwf = new RemisionWF();
            remisionwf.ShowDialog();

            //Inicializar vandera a true

            bandera = true;

            #region GuardarGridExcel
            /*saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Guardar Archivo en Excel";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Libro de Excel|*.xlsx|Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx";

            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);

                    //Cambiar propiedades del Workbook
                    ExcelApp.Columns.ColumnWidth = 20;

                    //Encabezados en las columnas de excel
                    for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    }

                    //llenar tabla
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();

                    bandera = true;

                    //MENSAJE DE EXITO :D
                    MessageBox.Show("Tabla de recibo exportada correctamente", "GAURDADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            #endregion
        }

        private void lotedelclientetbx_KeyUp(object sender, KeyEventArgs e)
        {
            llenardatagridinven();
        }
    }
}
