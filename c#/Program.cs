using System;

namespace dec11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello World!");


            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tapan proqram

            Console.WriteLine("edeleri daxil edin");
            var M1 = Console.ReadLine();
            var M = Convert.ToInt32(M1);
            var N1 = Console.ReadLine();
            var N = Convert.ToInt32(N1);
            var sum = 0;
            var count = 0;
            for (int i = M; M < N; M++)
            {
                if (M % 21 == 0)
                {
                    count++;
                    sum += M;
                }

            }
            if (count > 0)
            {
                Console.WriteLine(sum / count);

            }
            else
                Console.WriteLine("yanlisdir");


            // Verilmiş ədədin rəqəmləri cəmini tapan proqram


            Console.WriteLine("ededi daxil edin");
            var N2 = Console.ReadLine();
            var num = Convert.ToInt32(N2);
            var sum1 = 0;
            var x = 0;

            while (num != 0)
            {
                x = num % 10;
                sum1 += x;
                num = (num - x) / 10;

            }

            Console.WriteLine(sum1);


            //Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram

            Console.WriteLine("fesili tapin");
            var month1 = Console.ReadLine();
            var month = Convert.ToInt32(month1);

            if (month >= 1 && month <= 12)
            {
                if (month >= 3 && month <= 5)
                {
                    Console.WriteLine("yazdir");
                }
                else if (month >= 6 && month <= 8)
                {
                    Console.WriteLine("yaydir");
                }
                else if (month >= 9 && month <= 11)
                {
                    Console.WriteLine("payizdir");
                }
                else
                {
                    Console.WriteLine("qisdir");
                }


            }

            else
            {
                Console.WriteLine("deyer yanlisdir");
            }



            //Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram.
            //  Misalçün consoledan 5,10 və + daxil edilsə 5 və 10 - u toplayıb nəticəsini göstərsin.
            //Console - dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.

            var A1 = Console.ReadLine();
            var A = Convert.ToInt32(A1);
            var B1 = Console.ReadLine();
            var B = Convert.ToInt32(B1);
            var C1 = Console.ReadLine();
            var C = Convert.ToChar(C1);

            if (C == '+')
            {
                int sum3 = A + B;
                Console.WriteLine("sum;  " + sum3);
            }
            else if (C == '-')
            {
                int difference = A - B;
                Console.WriteLine("difference;  " + difference);
            }


            else if (C == '*')
            {
                int product = A * B;
                Console.WriteLine("product;  " + product);
            }
            else if (C == '/')
            {
                int quotinent = A / B;
                Console.WriteLine("quotinent;  " + quotinent);
            }
            else
            {
                Console.WriteLine("operation yanlisidr");
            }


            // Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki
            // rəqəmsiz daxil edilənədək.



            Console.WriteLine("adiniz daxil edin");
            var name = Console.ReadLine();

            bool letter = true;
            for (int h = 0; h < name.Length; h++)
            {
                if (name[h] == '0')
                {

                    letter = false;
                    break;
                }
                else if (name[h] == '1')
                {
                    letter = false;
                    break;

                }
                else if (name[h] == '2')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '3')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '4')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '5')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '6')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '7')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '8')
                {
                    letter = false;
                    break;
                }
                else if (name[h] == '9')
                {
                    letter = false;
                    break;


                }
                else
                {
                    continue;
                }

            }

            if (letter)
            {
                Console.WriteLine("adiniz; " + name);
            }
            else
            {
                Console.WriteLine("yeniden cehd edin");
            }

        }
    }
}

