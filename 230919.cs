using System;
namespace rensyu
{
    internal class rensyu
    {
        //問題
        //身長と体重を入力すると、BMIと肥満かどうかを表示するプログラム。
        //BMI25以上なら、肥満。25未満なら肥満でない。
        static void Main(string[] args)
        {
            //// 命名規則もう一度見直したほうが良いかもです。
            //// Parse失敗したら落ちません？TryParseしてエラー処理したほうがいいです。
            
            Console.WriteLine("身長を入力してください。[cm]");
            //double height = double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out double height);

            Console.WriteLine("体重を入力してください。[kg]");
            //double weight = double.Parse(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out double weight);

            double bmi = weight / (Math.Pow((height / 100), 2));
            Console.WriteLine("BMIは、" + bmi.ToString("F2") + "です。");

            if (bmi >= 25)
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