using SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class ReportGeneration
    {
        /// <summary>
        /// Report type
        /// </summary>
        public string ReportType { get; set; }

        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public void GenerateReport(Employee em)
        {
            try
            {
                // to create an exception
            }
            catch (Exception e)
            {

                throw;
            }
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }
    public class IReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
        public virtual void GenerateReport(Employee em)
        {
            // From base
        }
    }
    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate crystal report.
        }
    }
    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : IReportGeneration
    {
        public override void GenerateReport(Employee em)
        {
            // Generate PDF report.
        }
    }
}
