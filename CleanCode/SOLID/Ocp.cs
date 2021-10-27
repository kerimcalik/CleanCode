using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.GoodCode
{
    class Ocp
    {
        public class Employee
        {

        }

        //Ayrıca abstract sınıf oluşturulabilir yada Interface kullanılabilir
        public class ReportGeneration
        {
            public virtual void CreateReport(Employee employee)
            {
                
            }
        }

        public class CrystalReportGeneration: ReportGeneration
        {
            public override void CreateReport(Employee employee)
            {
                base.CreateReport(employee);
            }
        }

        public class PdfReportGeneration: ReportGeneration
        {
            public override void CreateReport(Employee employee)
            {                
                base.CreateReport(employee);
            }
        }

        public class ExcelReportGeneration:ReportGeneration
        {
            public override void CreateReport(Employee employee)
            {
                base.CreateReport(employee);
            }
        }
    }
}

namespace CleanCode.SOLID.BadCode
{
    public class Employee
    {

    }

    public class ReportGeneration
    {
        public string ReportType { get; set; }

        public void GenerateReport(Employee employee)
        {
            if (ReportType == "CRS")
            {

            }

            if (ReportType == "PDF")
            {

            }
        }

    }
}
