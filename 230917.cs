//訂正済み﻿
namespace rensyu
{
    public class Program
    {
        static void Main(string[] args)
        {
            //問題
            //入力した10進数を16進数に変換する

            Console.WriteLine("数字を入力してください");

            //// intにパースできない入力の時落ちませんか？
            //// →落ちないとは思いますが、エラー処理できてないですね。ループ処理の中で落ちません？
            int value = int.Parse(Console.ReadLine());

            //// 全体的に型推論使ったほうがよいです。
            var resultValue = new List<string>();

            for (int i = 0; ; i++)
            {
                int remainder = (int)(value % 16);
                resultValue.Add(remainder.ToString("X"));
                int quotient = (int)(value / 16);

                if (quotient >= 16) 
                {
                    value = quotient; 
                }
                else if (quotient == 0) 
                {
                    break; 
                }
                else
                {
                    resultValue.Add(quotient.ToString("X"));
                    break;
                }
            }
            //// 個人的な意見かもしれませんがローカル変数よりメンバ関数にしましょう。
            //→（質問）ローカル"関数"の間違いでしょうか？
            //// →すみません。そうです。
            
            resultValue.Reverse();

            Console.Write("入力した数字を16進数になおすと");
            foreach (var item in resultValue)
            {
                Console.Write(item);
            }
            Console.Write("です。");
        }
            ////コメントアウトしたコードはpushしないでください。
            //string ToHexa(int value)
            //{
                //string? hexaValue = null;
                //switch (value)
                //{
                //    case 10:
                //        hexaValue = "A";
                //        break;
                //    case 11:
                //        hexaValue = "B";
                //        break;
                //    case 12:
                //        hexaValue = "C";
                //        break;
                //    case 13:
                //        hexaValue = "D";
                //        break;
                //    case 14:
                //        hexaValue = "E";
                //        break;
                //    case 15:
                //        hexaValue = "F";
                //        break;
                //    default:
                //        hexaValue = value.ToString();
                //        break;
                //}
                //return hexaValue;
            //}
    }
}
