namespace rensyu
{
    internal class rensyu
    {
        //問題
        //最低温度と最高温度を入力すると温度計のメモリを表示するプログラムを作成せよ。
        //最低温度と最高温度としては10刻みの値を入力するとし、
        //入力される値はいずれも-90以上90以下とする。

        ///※もう少し改善の余地あり

        static void Main(string[] args)
        {
            Console.WriteLine("最低温度を入力してください");

            //// Parseで落ちますね。→エラー処理できてないですね。
            int.TryParse(Console.ReadLine(), out int minTemp);
            Console.WriteLine("最高温度を入力してください");
            int.TryParse(Console.ReadLine(), out int maxTemp);

            //// ↓のロジック何してるのかわからず。ほかの人が見た時にパッとわかるろじっくにしましょう。
            /// →まだよくわからないです。（後から自分でパッと見て読めるコードになってます？）
            //ここから最小値から10刻みで数字を表示（最大値を含むように）
            for (int i = minTemp; i < maxTemp+10;)
            {
                Console.Write(" "+i +"  ");
                i += 10;
            }

            Console.WriteLine();

            for (int i = 0; i <= (maxTemp - minTemp) / 10 + 1; i++)
            {
                Console.Write("--|--");
            }
        }
    }
}