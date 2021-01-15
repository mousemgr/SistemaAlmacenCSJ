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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SistemaAlmacen
{
    public partial class VerRecibo : Form
    {
        public VerRecibo()
        {
            InitializeComponent();
            cargarcbxcliente();
            llenardatagrid();
            crystalrpt("CRcliente");
        }

        public void crystalrpt(string parametro)
        {
            //Variable cliente

            CrystalReport1 crystalreport = new CrystalReport1();

            //ReportDocument crystalreport = new ReportDocument();
            //crystalreport.Load(@"C:\Users\LUISE\documents\visual studio 2013\SISJAG\SistemaAlmacen\SistemaAlmacen\CrystalReport1.rpt");
            crystalreport.SetDatabaseLogon("sa","Jaguar1");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = cbxcliente.Text;
            crParameterFieldDefinitions = crystalreport.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions[parametro];

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = crystalreport;
            crystalReportViewer1.Refresh();

            crystalReportViewer1.RefreshReport();
        }

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

        public void llenardatagrid()
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

            string fechadeinicio = dateTimePickerInicio.Value.ToString("dd/MM/yyyy");
            string fechadefin = dateTimePickerFin.Value.ToString("dd/MM/yyyy");

            try
            {
                var select = "SELECT LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, Posicion, FechaRecibo, Presentacion FROM ReciboAlmacen where Cliente = '" + cbxcliente.SelectedValue + "' and FechaRecibo between '" + fechadeinicio + "' and '" + fechadefin + "' ORDER BY Id_almacen desc";
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
                dataGridView1.Columns[2].HeaderCell.Value = "Master Code";
                dataGridView1.Columns[3].HeaderCell.Value = "Numero de Parte";
                dataGridView1.Columns[4].HeaderCell.Value = "Peso Neto";
                dataGridView1.Columns[5].HeaderCell.Value = "Peso Bruto";
                dataGridView1.Columns[6].HeaderCell.Value = "Piezas";
                dataGridView1.Columns[7].HeaderCell.Value = "Espesor";
                dataGridView1.Columns[8].HeaderCell.Value = "Ancho";
                dataGridView1.Columns[9].HeaderCell.Value = "Especificacion";
                dataGridView1.Columns[10].HeaderCell.Value = "Posicion";
                dataGridView1.Columns[11].HeaderCell.Value = "Fecha de Recibo";
                dataGridView1.Columns[12].HeaderCell.Value = "Presentacion";

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

            OpenCon.Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatagrid();
            crystalrpt("CRcliente");
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            llenardatagrid();
        }

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            llenardatagrid();
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
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    //llenar tabla
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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

    }
}
