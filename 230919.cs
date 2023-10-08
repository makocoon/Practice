//10月1日PR分訂正済み﻿

//問題
//身長と体重を入力すると、BMIと肥満かどうかを表示するプログラム。
//BMI25以上なら、肥満。25未満なら肥満でない。

using System;
namespace rensyu
{
    internal class rensyu
    {
        private const double standardBMI = 25;

        static void Main(string[] args)
        {
            //// Parse失敗したら落ちません？TryParseしてエラー処理したほうがいいです。
            //↓で実装しました。

            Console.WriteLine("身長を入力してください。[cm]");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                //何もしない
            }
            else
            {
                Console.WriteLine("入力が正しくありません。");
                Environment.Exit(1);
            }

            Console.WriteLine("体重を入力してください。[kg]");
            if (double.TryParse(Console.ReadLine(), out double weight))
            {
                //何もしない
            }
            else
            {
                Console.WriteLine("入力が正しくありません。");
                Environment.Exit(1);
            }
            double bmi = CalcBMI(height, weight);
            ShowBMIStatus(bmi);
        }

        private static double CalcBMI(double height, double weight)
        {
            return weight / (Math.Pow((height / 100), 2));
        }

        private static void ShowBMIStatus(double bmi)
        {
            string formattedBMI = bmi.ToString("F2");
            Console.WriteLine($"BMIは、{formattedBMI}です。");

            //// bmi >= 25が何さしてるのか、下のコード見ないと、
            //// わからないので、一時変数で受けたほうがいいです。
            //実装しました。
            if (bmi >= standardBMI)
            {
                Console.WriteLine("あなたは肥満です。");
            }
            else
            {
                Console.WriteLine("あなたは肥満ではありません。");
            }
        }
    }
}