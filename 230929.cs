//問題
//税抜き合計額を入力すると、消費税額、支払額、ポイントを表示するプログラムをかけ。
//消費税＝税抜き合計額に8％の消費税をあわせたもの。
//ポイントは税込み支払額に対して10％付与される。
//なお、計算で発生した1円未満は切り捨てとする。

namespace rensyu
{
    internal class rensyu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("金額（税抜き）を入力してください。");
            int.TryParse(Console.ReadLine(), out int price);
            double tax = 8;
            int taxPrice = (int)(price*tax/100);
            int taxedPrice = price + taxPrice;
            int pointPrice = (int)(taxedPrice * 0.1);
            Console.WriteLine($"消費税額：{taxPrice}円");
            Console.WriteLine($"支払額：{taxedPrice}円");
            Console.WriteLine($"ポイント付与分：{pointPrice}円");
        }
    }
}