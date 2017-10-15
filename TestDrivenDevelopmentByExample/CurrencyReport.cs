using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    /// <summary>
    /// レポート
    /// </summary>
    public class CurrencyReport
    {
        public Dictionary<UInt32, ReportRow> ReportList { get; private set; }
        private UInt32 ID;
        private Bank bank;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CurrencyReport()
        {
            this.ID = 0;
            this.ReportList = new Dictionary<uint, ReportRow>();
            this.bank = new Bank();
        }

        /// <summary>
        /// レポートの行を追加する
        /// </summary>
        /// <param name="brand">銘柄</param>
        /// <param name="stockNum">株数</param>
        /// <param name="stockValue">価格</param>
        /// <param name="currency">合計</param>
        public void AddReportRow(string brand, int stockNum, int stockValue, string currency)
        {
            this.ReportList.Add(this.ID, new ReportRow(this.ID, brand, stockNum, stockValue, currency));
            this.ID++;
        }

        /// <summary>
        /// レポートを文字列形式で取得する
        /// </summary>
        /// <returns>レポート</returns>
        public string GetCurrencyReport()
        {
            string report;
            // Header
            report =  "==================================================================================\r\n";
            report += string.Format(" {0, -20}{1, -20}{2, -20}{3, -20} \r\n", "Bland ", "Num of stock", "Value of stock", "Sum");
            report += "----------------------------------------------------------------------------------\r\n";

            // Body
            foreach(KeyValuePair<UInt32, ReportRow> pair in this.ReportList)
            {
                ReportRow row = pair.Value;
                report += string.Format(" {0, -20}{1, -20}{2, -20}{3, -20} \r\n", row.Brand, row.StockNum, row.StockValue.ToString() + " " + row.Currency, row.Sum.ToString() + " " + row.Currency);
            }

            // Footer
            report += "==================================================================================\r\n";
            return report;
        }
    }
}
