//問題
//入力された半径（cm）をもつ球の体積を単位ccで表示せよ。
//円周率は3.14とする

namespace rensyu
{
    internal class rensyu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("半径は？");
            double.TryParse(Console.ReadLine(), out double radius);
            double volume = 4 * Math.PI * Math.Pow(radius, 3) / 3;
            Console.WriteLine($"球の体積は{volume:F2}です。");
        }
    }
}