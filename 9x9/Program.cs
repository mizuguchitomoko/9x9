using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9x9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1～9まで増える変数を２つループさせる。
            for (int i = 1; i <= 9; i++) 
            {
                for(int n = 1; n <= 9; n++)
                {
                    Console.Write(i * n + " ");//積の間に空白
                }
                Console.Write("\r\n");//nが1～9までループしたら改行文字列を入れる
               
                //Console.WriteLine();//nが1～9までループしたら改行
            }
        }
    }
}
