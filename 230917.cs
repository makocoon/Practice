//10月1日PR分訂正済み﻿

//問題
//入力した10進数を16進数に変換する

using System.Runtime.CompilerServices;

namespace rensyu
{
    public class Program
    {
        private static List<string> _outputValue = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("数字を入力してください");
            //// 全体的に型推論使ったほうがよいです。

            //// intにパースできない入力の時落ちませんか？
            //// →落ちないとは思いますが、エラー処理できてないですね。ループ処理の中で落ちません？
            //↓で実装しました。
            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                ChangeValue(inputValue);
                DisplayResult();
            }
            else
            {
                Console.WriteLine("入力が正しくありません。");
            }
        }
        //// 個人的な意見かもしれませんがローカル関数よりメンバ関数にしましょう。
        //↓すみません、メンバ関数の命名規約曖昧なので、火曜日確認します。
        private static void ChangeValue(int value)
        {
            if (value == 0)
            {
                _outputValue.Add(value.ToString("X"));
            }
            while (value > 0)
            {
                var remainder = value % 16;
                _outputValue.Add(remainder.ToString("X"));
                value /= 16;
            }
        }
        private static void DisplayResult()
        {
            _outputValue.Reverse();

            Console.Write("入力した数字を16進数になおすと");
            foreach (var item in _outputValue)
            {
                Console.Write(item);
            }
            Console.Write("です。");
        }
    }
}
