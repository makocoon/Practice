//問題
//入力された整数が正か負かゼロかを分類するプログラムを作成せよ。
//入力が負の場合には絶対値を表示せよ。
using System.Linq.Expressions;

namespace rensyu
{
    internal class rensyu
    {
        static void Main(string[] args)
        {
            //// このインスタンスは...?
            var rensyu = new rensyu();

            Console.WriteLine("整数を入力してください。");
            //// Parse失敗したらExceptionでますね。
            double.TryParse(Console.ReadLine(), out double value);

            Console.WriteLine(rensyu.judgeValue(value));
        }

        private static string judgeValue(double value)
        {
            //// ↓は可読性がひくいですね。
            ////　簡潔に書いて,インラインにするのが一番よいですね。
            ///　（若干前回指摘が微妙でした。すみません。）

            //// コード例
            // if( value == 0) return "Zero";
            // return (value > 0) ? return "Positive" : $"Nagative. absolute value is {Math.Abs(changedValue)}"; 

            if (value == 0) //文字列を入力したときも"ゼロ"になってしまう
            {
                return "ゼロ";
            }
            else if (value > 0)
            {
                return "正";
            }
            else
            {
                //// Math.Abs使いましょう。
                double changedValue = Math.Abs(value);

                //// 文字列補間使いましょう。
                //// Console.WriteLine($"負。絶対値は{_changedValue}です。);
                return $"負。絶対値は{changedValue}です。";
            }
        }
    }
}