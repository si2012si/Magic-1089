using System;
using System.Text;

namespace Problem_count_1089
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            double count = 100;
            double count1 = 0;
           
            double sum;
            
            while (count <= 999)
            {
                sum = 0;
                count1 = 0;
                    count++;
                    string s = count.ToString();
                    char[] str = s.ToCharArray();
                    Array.Reverse(str);
                   
                  StringBuilder sb = new StringBuilder(str.Length);
                string value = sb.Append(str).ToString();
                count1 = Convert.ToDouble(value);
                 sum = count1 - count;
                Console.WriteLine("Число="+count);
                Console.WriteLine("Перевёртыш=" + count1);
                Console.WriteLine(count + "-" + count1 + "=" + sum);   

                Sum.Start(sum);
            }
        }
    }
    class Sum
    {

        public static void Start(double sum)
        {
            double count;
            double count1;
            count1 = 0;
            string s = sum.ToString();
            if (sum < 0)
                sum = sum * -1;
            char[] str = s.ToCharArray();
            Array.Reverse(str);

            StringBuilder sb = new StringBuilder(str.Length);
            string value = sb.Append(str).ToString();
            if (value[value.Length - 1] == '-')
                value = value.Trim('-');
            count1 = Convert.ToDouble(value);

            count = count1 + sum;
            Console.WriteLine(count1+"+"+sum+"="+count);
            Console.WriteLine("Магическое число:"+ count);
            Console.WriteLine("------------------------");
           
        }
    }
}
