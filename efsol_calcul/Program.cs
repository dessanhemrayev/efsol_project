using System;

namespace efsol_calcul
{
    class Program
    {
        static void plus(string s1, string s2)
        {
            double k, l, summa;

            k = Convert.ToDouble(s1);
            l = Convert.ToDouble(s2);
            summa = k + l;
            Console.WriteLine("Ответ:");
            Console.Write(" ");
            s1 = Convert.ToString(k);
            s2 = Convert.ToString(l);
            if ((s1.Length > s2.Length))
            {
                Console.WriteLine(s1);
                Console.Write("+");
                Console.WriteLine();
                for (int i = 0; i < s1.Length - s2.Length + 1; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(s2);
                Console.Write(" ");
                for (int i = 0; i < s1.Length; i++)
                {
                    Console.Write("-");

                }
                if (summa > 0)
                {
                    Console.Write(" ");
                }
            }
            else
            {
                Console.WriteLine(s2);
                Console.Write("+");
                Console.WriteLine();
                for (int i = 0; i < s2.Length - s1.Length + 1; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(s1);
                Console.Write(" ");
                for (int i = 0; i < s2.Length; i++)
                {
                    Console.Write("-");

                }

            }
            Console.WriteLine();

          
                Console.Write(" ");
          
            Console.WriteLine(summa);

        }
        static void minus(string s1, string s2)
        {
            double k, l, raznost;

            k = Convert.ToDouble(s1);
            l = Convert.ToDouble(s2);
            raznost = k - l;
            Console.WriteLine("Ответ:");
            Console.Write(" ");
            if ((s1.Length > s2.Length))
            {
                Console.WriteLine(s1);
                Console.Write("-");
                Console.WriteLine();
                for (int i = 0; i < s1.Length - s2.Length + 1; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(s2);
                Console.Write(" ");
                for (int i = 0; i < s1.Length; i++)
                {
                    Console.Write("-");

                }

            }
            else
            {
                Console.WriteLine(s2);
                Console.Write("-");
                Console.WriteLine();
                for (int i = 0; i < s2.Length - s1.Length + 1; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(s1);
                Console.Write(" ");
                for (int i = 0; i < s2.Length; i++)
                {
                    Console.Write("-");

                }

            }
            Console.WriteLine();

            if (raznost>0)
            {
                Console.Write(" ");

            }
            Console.WriteLine(raznost);


        }

        static void multiplications(string s1, string s2)
        {
            double k, l, multip;

            k = Convert.ToDouble(s1);
            l = Convert.ToDouble(s2);
            multip = k * l;
            if (k < 0) { k *= -1; }
            if (l < 0) { l *= -1; }
            Console.WriteLine("Ответ:");
            Console.Write(" ");
            s1 = Convert.ToString(k);
            s2 = Convert.ToString(l);

            if ((s1.Length >= s2.Length))
            {

                for (int i = 0; i < s2.Length; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s1);
                Console.WriteLine("*");
                for (int i = 0; i <= (s1.Length - s2.Length) + s2.Length; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s2);
                for (int i = 0; i <= s2.Length; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < s1.Length; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

                int kl = 0;
                double mulp = 0;

                char[] chislo = s2.ToCharArray();
                int tik = s2.Length;
                while (tik > 0)
                {
                    for (int i = 0; i <= tik; i++)
                    {
                        Console.Write(" ");
                    }

                    kl = Convert.ToInt32(chislo[tik - 1].ToString());
                    mulp = k * kl;
                    Console.WriteLine(mulp);
                    tik--;
                }
                if (s2.Length != 1)
                {
                    for (int i = 1; i <= (s1.Length + s2.Length) + 1; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < s1.Length/2; i++)
                    {
                        Console.Write(" ");
                    }
 
                    Console.WriteLine(multip);
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s2);
                Console.WriteLine("*");
                for (int i = 0; i <= (s2.Length - s1.Length) + s1.Length; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s1);
                for (int i = 0; i <= s1.Length; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < s2.Length; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

                int kl = 0;
                double mulp = 0;

                char[] chislo = s1.ToCharArray();
                int tik = s1.Length;
                while (tik > 0)
                {
                    for (int i = 0; i <= tik; i++)
                    {
                        Console.Write(" ");
                    }

                    kl = Convert.ToInt32(chislo[tik - 1].ToString());
                    mulp = l * kl;
                    Console.WriteLine(mulp);


                    tik--;
                }
                if (s1.Length != 1)
                {
                    for (int i = 1; i <= (s1.Length + s2.Length) + 1; i++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                    for (int i = 0; i < s1.Length-1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(multip);
                    Console.WriteLine();
                }
            }
        }
        static void division(string s1, string s2)
        {
            double k, l, multip;

            k = Convert.ToInt32(s1);
            l = Convert.ToInt32(s2);
            multip = k * l;
            if (k < 0) { k *= -1; }
            if (l < 0) { l *= -1; }
            Console.WriteLine("Ответ:");
            Console.Write(" ");
            s1 = Convert.ToString(k);
            s2 = Convert.ToString(l);
            int start = 0;
            int stop = 0;
            double result = 0;
            double ost = 0;
            string otwet = "";
            string str = "";
            while (true)
            {
                 str = s1.Substring(start, stop);
                if (Convert.ToInt32(str)>= Convert.ToInt32(s2)) 
                {
                    result = Convert.ToInt32(str) / Convert.ToInt32(s2);
                    ost = Convert.ToInt32(str) %Convert.ToInt32(s2);
                    otwet += result.ToString();
                    //s1.Remove(start, stop );
                    // 

                    //start = 
                    stop=0;
                    
                
                    if (ost == 0 && stop>s1.Length)
                    {
                        Console.WriteLine(otwet);
                       
                        break; 
                    }
                   
                   

                }
                if (ost == 0)
                { s1.Replace(str, ""); }
                    s1.Replace(str, ost.ToString());
                stop++;
            }


            Console.ReadKey();


        }

        static void Main(string[] args)
        {
            try
            {
                string st1 = "";
                string st2 = "";
                string st3 = "";
                string wopros = "";
                bool fl = true;
                while (fl)
                {
                    Console.Write("Введите первое число:");
                    st1 = Console.ReadLine();
                    Console.Write("Введите второе число:");
                    st2 = Console.ReadLine();

                    Console.Write("Введите знак операций:");
                    st3 = Console.ReadLine();
                    char ch = Convert.ToChar(st3);
                    switch (ch)
                    {
                        case '+': plus(st1, st2); break;
                        case '-': minus(st1, st2); break;
                        case '*': multiplications(st1, st2); break;
                        case '/': division(st1, st2); break;
                        default:
                            Console.Write("Я не понял вас!");
                            break;
                    }
                    Console.WriteLine("Вы хотите продолжать? (yes/no)");
                    wopros = Console.ReadLine();
                    if (wopros == "yes")
                    { fl = true; }
                    else if (wopros == "no" || wopros != "yes")
                    {
                        Console.WriteLine("Bye ! ");
                        fl = false;
                    }
                }

            }
            catch (Exception)
            {

                Console.Write("Ошибка!");
            }


        }
    }
}
