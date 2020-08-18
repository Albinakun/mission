using System;

namespace mission
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;

            Console.WriteLine("勤務先の時給を入力してください↓");
            string moneyInput = Console.ReadLine();/*時給を入力させる*/

            int money = System.Convert.ToInt32(moneyInput);/*stringとして時給を入力させたものをintに変換*/

            Console.WriteLine("今月の勤務時間を入力してください(時数)↓");
            string timeInput = Console.ReadLine();/*勤務時間を入力させる*/

            int time = System.Convert.ToInt32(timeInput);/*stringとして勤務時間を入力させたものをintに変換*/

            Console.WriteLine("入力していただいたデータをもとに、今月の貴方のお給料をお知らせします。");
            Console.WriteLine("計算中…");

            Money(Result, money, time);

            Console.WriteLine("今月の貴方のお給料が出ました。");
            Console.ReadLine();
            Console.WriteLine("今月の貴方のお給料は" + Result + "円です。");
            Console.ReadLine();
            Console.WriteLine("お疲れ様でした。");
            Console.ReadLine();

        }

       static int Money(int n,int m,int i)
        {
            n = m * i;

            return n;
        }
        
    }
}
