using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using FastReport;
using FastReport.Barcode;


namespace FReportCoil
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
            FReport.Load(FilePath);
            FReport.Preview = rptPre;
        }

        public FmMain(string coilNumber) : this()
        {
            CoilNumber = coilNumber;
        }

        public string CoilNumber { get; set; }

        public static string FilePath
        {
            get { return AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "小卷标签.frx"; }
        }

        private void RegisterData()
        {
            //DataTable dt = tb_weigh_datalineDetails.QueryWeighDetails(CoilNumber);
            //FReport.RegisterData(dt, "tb_weigh_datalineDetails");
        }

        private void SetParams()
        {
            //tb_weigh_datalineinfo dl = tb_weigh_datalineinfo.GetByCoilNumber(CoilNumber);
            FReport.SetParameterValue("pCoilNumber", CoilNumber);
            //barcode.Text = "hello";
            //FReport.SetParameterValue("pSpecification", dl.Specification);

//            string model = string.IsNullOrWhiteSpace(dl.Attribute10) || dl.Attribute10=="0"
//                ? string.Format("{0}*{1}", dl.Attribute8, dl.Attribute9)
//                : string.Format("{0}*{1}*{2}", dl.Attribute8, dl.Attribute9, dl.Attribute10);
//
//            FReport.SetParameterValue("pModel", model);
//            FReport.SetParameterValue("pSuttle", dl.Suttle);
        }

        private void PreviewReport()
        {
            if (FReport.IsRunning)
                return;
            FReport.Show();
        }

        public void RefreshReport()
        {
            RegisterData();
            SetParams();
            PreviewReport();
        }

        public void Print()
        {
            if (FReport.Prepare())
            {
                FReport.PrintPrepared(LocalPrinter.DefaultPrintSettings);
            }
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }
    }

    public class LocalPrinter
    {
        private static readonly PrintDocument FPrintDocument = new PrintDocument();

        public static PrinterSettings DefaultPrintSettings
        {
            get { return FPrintDocument.PrinterSettings; }
        }

        /// <summary>
        ///     获取本机默认打印机名称
        /// </summary>
        public static String DefaultPrinter
        {
            get { return FPrintDocument.PrinterSettings.PrinterName; }
        }

        /// <summary>
        ///     获取本机的打印机列表。列表中的第一项就是默认打印机。
        /// </summary>
        public static List<String> GetLocalPrinters()
        {
            var fPrinters = new List<string> {DefaultPrinter};
            foreach (String fPrinterName in PrinterSettings.InstalledPrinters)
            {
                if (!fPrinters.Contains(fPrinterName))
                    fPrinters.Add(fPrinterName);
            }
            return fPrinters;
        }
    }
}