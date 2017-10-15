namespace TestDrivenDevelopmentByExample
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("テスト駆動開発");
            System.Console.WriteLine("第1部 多国通貨  C#, MSTest版");

            CurrencyReport report = new CurrencyReport();
            report.AddReportRow(brand: "IBM", stockNum: 1000, stockValue: 25, currency: "USD");
            report.AddReportRow(brand: "Novartis", stockNum: 400, stockValue: 150, currency: "CHF");
            report.AddReportRow(brand: "GE", stockNum: 400, stockValue: 100, currency: "USD");

            System.Console.WriteLine(report.GetCurrencyReport());
        }
    }
}
