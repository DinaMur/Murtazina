using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
 
 int m11 = 0, m3 = 0, m33 = 0, r, max = 0, dat, res, i, N;
            try
            {


                N = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < N; i++)
                {
                    dat = Convert.ToInt32(Console.ReadLine());
                    if (dat % 11 == 0 && dat % 3 > 0 && dat > m11)
                    {
                        m11 = dat;
                    }
                    if (dat % 3 == 0 && dat % 11 > 0 && dat > m3)
                    {
                        m3 = dat;
                    }
                    if (dat % 33 == 0 && dat > m33)
                    {
                        if (m33 > max)
                        {
                            max = m33;
                            m33 = dat;
                        }
                        else
                        {
                            if (dat > max)
                            {
                                max = dat;
                            }
                        }

                    }
                    r = Convert.ToInt32(Console.ReadLine());
                    if (m11 * m3 < m33 * max)
                    {
                        res = m33 * max;
                    }
                    else
                    {
                        res = m11 * m3;
                        Console.WriteLine("Вычисленное контрольное значение {0}", res);
                    }
                    if (r == res)
                    {
                        Console.WriteLine("Контроль пройден");
                    }
                    else
                    {
                        Console.WriteLine("Контроль не пройден");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение!");
            }
 

     }
   }
 }
