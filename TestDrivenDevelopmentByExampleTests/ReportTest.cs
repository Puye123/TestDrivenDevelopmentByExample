using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentByExample;

namespace TestDrivenDevelopmentByExampleTests
{
    [TestClass]
    public class ReportTest
    {
        [TestMethod]
        public void TestReportRowUSD()
        {
            ReportRow reportRow = new ReportRow(id: 0, brand: "IBM", stockNum: 1000, stockValue: 25, currency: "USD");
            var expected = 25000;
            Assert.AreEqual(reportRow.Sum, expected);
        }

        [TestMethod]
        public void TestReportAddReportRow()
        {
            CurrencyReport report = new CurrencyReport();
            report.AddReportRow(brand: "IBM", stockNum: 1000, stockValue: 25, currency: "USD");
            ReportRow reportRow = new ReportRow(id: 0, brand: "IBM", stockNum: 1000, stockValue: 25, currency: "USD");
            Assert.AreEqual(reportRow, report.ReportList[0]);

            report.AddReportRow(brand: "Novartis", stockNum: 400, stockValue: 150, currency: "CHF");
            ReportRow reportRow2 = new ReportRow(id: 1, brand: "Novartis", stockNum: 400, stockValue: 150, currency: "CHF");
            Assert.AreEqual(reportRow2, report.ReportList[1]);
        }

        [TestMethod]
        [Description("空行の場合")]
        public void TestReportGetCurrencyReport_01()
        {
            CurrencyReport report = new CurrencyReport();
            var expected = @"==================================================================================
 Bland               Num of stock        Value of stock      Sum                  
----------------------------------------------------------------------------------
==================================================================================
";
            Assert.AreEqual(report.GetCurrencyReport(), expected);
        }

        [TestMethod]
        [Description("行が追加されている場合")]
        public void TestReportGetCurrencyReport_02()
        {
            CurrencyReport report = new CurrencyReport();
            report.AddReportRow(brand: "IBM", stockNum: 1000, stockValue: 25, currency: "USD");
            report.AddReportRow(brand: "Novartis", stockNum: 400, stockValue: 150, currency: "CHF");

            var expected = @"==================================================================================
 Bland               Num of stock        Value of stock      Sum                  
----------------------------------------------------------------------------------
 IBM                 1000                25 USD              25000 USD            
 Novartis            400                 150 CHF             60000 CHF            
==================================================================================
";
            Assert.AreEqual(report.GetCurrencyReport(), expected);
        }
    }
}
