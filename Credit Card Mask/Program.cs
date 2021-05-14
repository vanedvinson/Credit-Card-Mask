using System;
using System.Text;

namespace Credit_Card_Mask
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Make the last 4 digits visible

            string s1 = "Six";
            string s2 = "Seven";
            string s3 = "eight";
            string s4 = "Nineteen";
            

            Console.WriteLine(Maskify(s1));
            Console.WriteLine(Maskify(s2));
            Console.WriteLine(Maskify(s3));
            Console.WriteLine(Maskify(s4));

            string Maskify(string cc)
            {
                var temp = new StringBuilder();
                if (cc.Length > 4)
                {
                    for(int i = 0; i < cc.Length; i++)
                    {
                        if (i < (cc.Length - 4))
                        {
                            temp.Append('#');
                        }
                        else
                        {
                            temp.Append(cc[i]);
                        }

                    }
                    return temp.ToString();
                }
                return cc.ToString();
            }
        }

        
    }
}
