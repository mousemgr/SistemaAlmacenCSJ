using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace SistemaAlmacen
{
    public partial class RemisionWF : Form
    {
        public RemisionWF()
        {
            InitializeComponent();
            crystalrpt();

            /*RemisionAlmacen ob = new RemisionAlmacen();
            TextObject text = (TextObject)ob.ReportDefinition.Sections["Section1"].ReportObjects["Text21"];
            text.Text = "pofavor";
            crystalReportViewer1.ReportSource = ob;*/

        }

        public void crystalrpt()
        {
            string NumeroDeRemision = "JAG-R"+EmbarqueAlmacen.NumRemision;
            string NomTrans = EmbarqueAlmacen.NombreTransportista;
            string EmbarcadoA = EmbarqueAlmacen.Destino;
            string ClienteEmbarque = EmbarqueAlmacen.ClienteRem;
            string FechaRemision = EmbarqueAlmacen.FechaRem;

            //Variable cliente
            RemisionAlmacen crystalreport = new RemisionAlmacen();

            //ReportDocument crystalreport = new ReportDocument();
            //crystalreport.Load(@"C:\Users\LUISE\documents\visual studio 2013\SISJAG\SistemaAlmacen\SistemaAlmacen\RemisionAlmacen.rpt");
            crystalreport.SetDatabaseLogon("sa", "Jaguar1");

            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            TextObject text = (TextObject)crystalreport.ReportDefinition.Sections["Section1"].ReportObjects["Text21"];
            text.Text = NomTrans;

            TextObject text2 = (TextObject)crystalreport.ReportDefinition.Sections["Section1"].ReportObjects["Text22"];
            text2.Text = EmbarcadoA;

            TextObject text3 = (TextObject)crystalreport.ReportDefinition.Sections["Section1"].ReportObjects["Text23"];
            text3.Text = ClienteEmbarque;

            TextObject text4 = (TextObject)crystalreport.ReportDefinition.Sections["Section1"].ReportObjects["Text24"];
            text4.Text = FechaRemision;

            crParameterDiscreteValue.Value = NumeroDeRemision;
            crParameterFieldDefinitions = crystalreport.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["NumeroREM"];

            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            crystalReportViewer1.ReportSource = crystalreport;
            crystalReportViewer1.Refresh();

            crystalReportViewer1.RefreshReport();
        }
    }
}
