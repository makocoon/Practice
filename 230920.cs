//10月1日PR分訂正済み﻿

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
            //すみません。謎なことしていました。

            Console.WriteLine("整数を入力してください。");
            //// Parse失敗したらExceptionでますね。
            //↓のように実装しました。
            var uncheckedValue = Console.ReadLine();
            if (double.TryParse(uncheckedValue, out double checkedValue))
            {
                Console.WriteLine(judgeValue(checkedValue));
            }
            else if(uncheckedValue is string)
            {
                Console.WriteLine("入力が正しくありません。");
            }
        }

        private static string judgeValue(double value)
        {
            //// ↓は可読性がひくいですね。
            ////　簡潔に書いて,インラインにするのが一番よいですね。
            ///　（若干前回指摘が微妙でした。すみません。）

            //// コード例
            // if( value == 0) return "Zero";
            // return (value > 0) ? return "Positive" : $"Nagative. absolute value is {Math.Abs(changedValue)}"; 
            if (value == 0) return "セロ";
            return (value > 0) ? "正": $"負。絶対値は{Math.Abs(value)}です。";

        }
    }
}