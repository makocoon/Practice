//問題
//入力された整数が正か負かゼロかを分類するプログラムを作成せよ。
//入力が負の場合には絶対値を表示せよ。
namespace rensyu
{
    internal class rensyu
    {
        static void Main(string[] args)
        {
            var rensyu = new rensyu();

            Console.WriteLine("整数を入力してください。");
            //// 命名規則見直しましょう。
            //// Parse失敗したらExceptionでますね。
            double.TryParse(Console.ReadLine(), out double value);

            Console.WriteLine("judgeValue(value)");
        }
        //// こっから下のロジックは関数に抜いたほうが読みやすいですね。
        private string judgeValue(double value)
        {

            if (value > 0)
            {
                return "正";
            }
            else if (value < 0)
            {

                //// Math.Abs使いましょう。
                double changedValue = Math.Abs(value);

                //// 文字列補間使いましょう。
                //// Console.WriteLine($"負。絶対値は{_changedValue}です。);
                return $"負。絶対値は{changedValue}です。";
            }
            else if (value == 0)
            {
                return "ゼロ";
            }
        }
    }

}