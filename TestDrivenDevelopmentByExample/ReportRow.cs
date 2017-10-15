using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentByExample
{
    /// <summary>
    /// 他国通貨レポートの行を表すクラス
    /// </summary>
    public class ReportRow
    {
        private UInt32 _id;
        /// <summary>
        /// オブジェクト固有のID
        /// </summary>
        public uint Id { get => _id; set => _id = value; }

        private string _brand;
        /// <summary>
        /// 銘柄
        /// </summary>
        public string Brand { get => _brand; private set => _brand = value; }

        private int _stockNum;
        /// <summary>
        /// 株数
        /// </summary>
        public int StockNum { get => _stockNum; private set => _stockNum = value; }
        
        private int _stockValue;
        /// <summary>
        /// 価格
        /// </summary>
        public int StockValue { get => _stockValue; private set => _stockValue = value; }
        
        private string _currency;
        /// <summary>
        /// 通貨の種類
        /// </summary>
        public string Currency { get => _currency; private set => _currency = value; }

        /// <summary>
        /// 合計
        /// </summary>
        private int _sum;
        public int Sum { get => _sum; set => _sum = value; }

        /// <summary>
        /// コンストラクタ 株数と価格から合計価格を求める
        /// </summary>
        /// <param name="id">このオブジェクトのID</param>
        /// <param name="brand">銘柄</param>
        /// <param name="stockNum">株数</param>
        /// <param name="stockValue">価格</param>
        /// <param name="currency">通貨の種類</param>
        public ReportRow(UInt32 id, string brand, int stockNum, int stockValue, string currency)
        {
            this.Id = id;
            this.Brand = brand;
            this.StockNum = stockNum;
            this.StockValue = stockValue;
            this.Currency = currency;
            this.Sum = CalculateSum();
        }

        /// <summary>
        /// 株数と価格から合計価格を求める
        /// </summary>
        /// <returns>合計価格</returns>
        private int CalculateSum()
        {
            Money money;
            switch (this.Currency)
            {
                case "USD":
                    money = Money.Dollar(this.StockValue);
                    break;
                case "CHF":
                    money = Money.Franc(this.StockValue);
                    break;
                default:
                    return 0;
            }
            Bank bank = new Bank();
            return bank.Reduce(money.Times(this.StockNum), this.Currency).amount;
        }

        /// <summary>
        /// IDを元にオブジェクトが等価かどうかを判定する
        /// </summary>
        /// <param name="obj">比較対象</param>
        /// <returns>判定値</returns>
        public override bool Equals(object obj)
        {
            var row = obj as ReportRow;
            return row != null &&
                   Id == row.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
