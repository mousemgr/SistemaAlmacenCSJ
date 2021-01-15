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
using System.Threading;
using System.Runtime.InteropServices;
using System.Security;

namespace SistemaAlmacen
{
    public partial class InventarioAlmacen : Form
    {
        public InventarioAlmacen()
        {
            InitializeComponent();
            cargarcbxcliente();
            llenardatagrid();
            sumartotalpesoneto();
            crystalrpt("CrCliente");
        }

        public void crystalrpt(string parametro)
        {
            //Variable cliente

            CrystalReport2 crystalreport = new CrystalReport2();

            //ReportDocument crystalreport = new ReportDocument();
            //crystalreport.Load(@"C:\Users\LUISE\documents\visual studio 2013\SISJAG\SistemaAlmacen\SistemaAlmacen\CrystalReport2.rpt");

            //crystalreport.DataSourceConnections[0].SetConnection("WIN-SERVER\\JAGUARIRA", "SistemaAlmacen", "sa", "Jaguar1");
            crystalreport.SetDatabaseLogon("sa", "Jaguar1", "WIN-SERVER\\JAGUARIRA", "SistemaAlmacen");

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
                var select = "SELECT LoteInterno, LoteCliente, MaterCode, NumParte, PesoNeto, PesoBruto, Pzs, Espesor, Ancho, Especificacion, Posicion, FechaRecibo, Presentacion FROM InventarioAlmacen where Cliente = '" + cbxcliente.SelectedValue + "' and FechaRecibo between '" + fechadeinicio + "' and '" + fechadefin + "' ORDER BY Id_almacen desc";
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

        private void cbxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatagrid();
            sumartotalpesoneto();
            crystalrpt("CrCliente");
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
                    MessageBox.Show("Tabla de inventario exportada correctamente", "GAURDADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FAVOR DE INFORMAR AL DEPARTAMENTO DE SISTEMAS " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void sumartotalpesoneto()
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
            String QuerySumPesoNeto = "SELECT SUM(PesoNeto) AS Expr1 FROM InventarioAlmacen WHERE Cliente = '" + cbxcliente.SelectedValue + "'";

            try
            {
                //CONVERTIR CONSULTA MAYOR CONSECUTIVO DEL CLIENTE A INT
                SqlCommand SumPesoNeto = new SqlCommand(QuerySumPesoNeto, OpenCon);

                

                if (SumPesoNeto.ExecuteScalar() != DBNull.Value)
                    tbxsumpeso.Text = Convert.ToString(SumPesoNeto.ExecuteScalar());
                else
                    tbxsumpeso.Text = "0";
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

        private void InventarioAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.A) || e.KeyChar == (char)(Keys.S) || e.KeyChar == (char)(Keys.D) || e.KeyChar == (char)(Keys.F) || e.KeyChar == (char)(Keys.Enter))
            {
                try
                {
                    AsignarConsola();
                    Main2();
                    LiberarConsola();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Solo se puede jugar una vez :(  " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region JUEGO

        //CONSOLA 

        public static int AsignarConsola()
        {
            return AllocConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        public static int LiberarConsola()
        {
            return FreeConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        // JUEGO SNAKE

        static void Main2()
        {
            var score = 0;
            var speed = 100;
            var foodPosition = Point.Empty;
            var screenSize = new Size(60, 20);
            var snake = new Queue<Point>();
            var snakeLength = 3;
            var currentPosition = new Point(0, 9);
            snake.Enqueue(currentPosition);
            var direction = Direction.Right;

            DrawScreen(screenSize);
            ShowScore(score);

            while (MoveSnake(snake, currentPosition, snakeLength, screenSize))
            {
                Thread.Sleep(speed);
                direction = GetDirection(direction);
                currentPosition = GetNextPosition(direction, currentPosition);

                if (currentPosition.Equals(foodPosition))
                {
                    foodPosition = Point.Empty;
                    snakeLength++;
                    score += 10;
                    ShowScore(score);
                }

                if (foodPosition == Point.Empty)
                {
                    foodPosition = ShowFood(screenSize, snake);
                }
            }

            Console.ResetColor();
            Console.SetCursorPosition(screenSize.Width / 2 - 4, screenSize.Height / 2);
            Console.Write("Perdiste :( ");
            Thread.Sleep(2000);
            Console.ReadKey();
        }

        private static void DrawScreen(Size size)
        {
            Console.Title = "Snake";
            Console.WindowHeight = size.Height + 2;
            Console.WindowWidth = size.Width + 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            for (int row = 0; row < size.Height; row++)
            {
                for (int col = 0; col < size.Width; col++)
                {
                    Console.SetCursorPosition(col + 1, row + 1);
                    Console.Write(" ");
                }
            }
        }

        private static bool MoveSnake(Queue<Point> snake, Point targetPosition, int snakeLength, Size screenSize)
        {
            var lastPoint = snake.Last();

            if (lastPoint.Equals(targetPosition)) return true;

            if (snake.Any(x => x.Equals(targetPosition))) return false;

            if (targetPosition.X < 0 || targetPosition.X >= screenSize.Width
                    || targetPosition.Y < 0 || targetPosition.Y >= screenSize.Height)
            {
                return false;
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(lastPoint.X + 1, lastPoint.Y + 1);
            Console.WriteLine(" ");

            snake.Enqueue(targetPosition);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(targetPosition.X + 1, targetPosition.Y + 1);
            Console.Write(" ");

            // Quitar cola
            if (snake.Count > snakeLength)
            {
                var removePoint = snake.Dequeue();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(removePoint.X + 1, removePoint.Y + 1);
                Console.Write(" ");
            }
            return true;
        }

        private static Direction GetDirection(Direction currentDirection)
        {
            if (!Console.KeyAvailable) return currentDirection;

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    if (currentDirection != Direction.Up)
                        currentDirection = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentDirection != Direction.Right)
                        currentDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (currentDirection != Direction.Left)
                        currentDirection = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    if (currentDirection != Direction.Down)
                        currentDirection = Direction.Up;
                    break;
            }
            return currentDirection;
        }

        private static Point GetNextPosition(Direction direction, Point currentPosition)
        {
            Point nextPosition = new Point(currentPosition.X, currentPosition.Y);
            switch (direction)
            {
                case Direction.Up:
                    nextPosition.Y--;
                    break;
                case Direction.Left:
                    nextPosition.X--;
                    break;
                case Direction.Down:
                    nextPosition.Y++;
                    break;
                case Direction.Right:
                    nextPosition.X++;
                    break;
            }
            return nextPosition;
        }

        private static Point ShowFood(Size screenSize, Queue<Point> snake)
        {
            var foodPoint = Point.Empty;
            var snakeHead = snake.Last();
            var rnd = new Random();
            do
            {
                var x = rnd.Next(0, screenSize.Width - 1);
                var y = rnd.Next(0, screenSize.Height - 1);
                if (snake.All(p => p.X != x || p.Y != y)
                    && Math.Abs(x - snakeHead.X) + Math.Abs(y - snakeHead.Y) > 8)
                {
                    foodPoint = new Point(x, y);
                }

            } while (foodPoint == Point.Empty);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(foodPoint.X + 1, foodPoint.Y + 1);
            Console.Write(" ");

            return foodPoint;
        }

        private static void ShowScore(int score)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(1, 0);
            Console.Write("Puntuación:" + score.ToString("00000000"));
        }

        #endregion
    }

    internal enum Direction
    {
        Down, Left, Right, Up
    }
}
