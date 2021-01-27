using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Amount = {100,200,300,500,1000,2000,4000,8000,16000,32000,64000,125000
                               ,250000,500000,1000000,
                           };
            char[] Ans = new char[15];
            char[] Key = new char[15];
            
            int choice = int.Parse(Console.ReadLine());
            int[] Prize = new int[choice];
            int correct=0;
            for (int i = 0; i < choice; i++)
            {
                string temp = Console.ReadLine();
                Key = temp.ToCharArray();
                temp = Console.ReadLine();
                Ans = temp.ToCharArray();
                for (int j = 0; j <Ans.Length; j++)
                {
                    if (Ans[j] == Key[j])
                    {
                        correct++;
                        Prize[i]=Amount[j];
                    }
                    else if (Ans[j]!=Key[j])
                    {
                        if (correct >= 5 && correct < 10)
                            Prize[i] = Amount[4];
                        else if (correct >= 10 && correct<15)
                            Prize[i] = Amount[9];
                        
                        break;
                    }
                }
            }

            for (int m = 0; m < choice; m++)
            {
                Console.WriteLine("$"+Prize[m]);
            }

            Console.ReadLine();
        }
    }
}
