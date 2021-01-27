
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b,temp, result = "" ;
            int count;
            String[] text;
            

            DateTime time1;
            DateTime time2;

            File.WriteAllText(@"C:\Users\farha\Desktop\SpeedP\Problem 2\Time.txt", "");
           count = int.Parse(Console.ReadLine());
          
            for (int i = 0; i < count; i++ )
            {
                temp=Console.ReadLine();
                text = temp.Split(' ');
                a = text[0];
                b = text[1];

                time1 = DateTime.Parse(a);
                
                time2 = DateTime.Parse(b);

                text = a.Split(':');
                String[] text2 = b.Split(':');
                int num1=int.Parse(text[0]);
                int num2=int.Parse(text2[0]);


                if (num2 < num1)
                {
                  //  Console.WriteLine(time2);
                    time2=time2.AddDays(1);
                  //  Console.WriteLine(time2);
                }
                
                TimeSpan timeDifference = time2.Subtract(time1);

                result=timeDifference.ToString();
                
                text= result.Split(':');
                
                result = "";
                for (int j = 0; j < 3; j++ )
                {
                    if (j == 0)
                        result += text[j] + " HOURS ";
                    else if (j==1)
                        result += text[j] + " MINUTES ";
                    else if (j==2)
                        result += text[j] + " SECONDS ";
                }
 
                result += "\n";
                
                
                File.AppendAllText(@"C:\Users\farha\Desktop\SpeedP\Problem 2\Time.txt",result);
                

            }
           String output = File.ReadAllText(@"C:\Users\farha\Desktop\SpeedP\Problem 2\Time.txt");
          Console.WriteLine(output);



            Console.ReadLine();
            
            
        }
    }
}
