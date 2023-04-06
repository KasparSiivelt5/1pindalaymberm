using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start:

            Console.Title = "Kuju valimine ja arvutamine"; //aknale nime panemine
            Console.WriteLine("Vali, mis kujundit soovid arvutada ja kujutada ning kirjuta konsoolile");

            Console.WriteLine("\n1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");
            Console.WriteLine("5. Maja");

            string shape = Console.ReadLine();

            switch (shape)
            {
                case "1":
                    Quadrilateral();
                    break;

                case "2":
                    Diamond();
                    break;

                case "3":
                    Rectangle();
                    break;

                case "4":
                    Triangle();
                    break;

                case "5":
                    House();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            Console.ReadKey();
            //goto Start;



        }

        private static void Quadrilateral()
        {
            Console.WriteLine("\nSisesta ruudu ühe külje mõõtühik sentimeetrites: ");
            double quadrilateral = double.Parse(Console.ReadLine());

            Console.WriteLine("Ruudu ümbermõõt: " + 4 * quadrilateral);
            Console.WriteLine("Ruudu pindala: " + quadrilateral * quadrilateral);
            //Math.PI;

            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Diamond()
        {
            double i, j, diamond;

            Console.WriteLine("\nSisesta teemanti raadiuse mõõtühik sentimeetrites");
            diamond = double.Parse(Console.ReadLine());

            double height = diamond;
            double width = 2 * diamond;

            double radius = Math.Sqrt(Math.Pow(height / 2, 2) + Math.Pow(width / 2, 2));

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Teemandi ümbermõõt: " + perimeter + " cm");
            Console.WriteLine("Teemandi pindala: " + area + " cm2");

            for (i = 0; i <= diamond; i++)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = diamond - 1; i >= 1; i--)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        private static void Rectangle()
        {
            Console.WriteLine("\nSisesta ristküliku kahe külje mõõtühik sentimeetrites");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            double perimeter = 2 * (a + b);

            Console.WriteLine("Ristküliku pindala on: " + area + " ruutsentimeetrit");
            Console.WriteLine("Ristküliku ümbermõõt on: " + perimeter + " sentimeetrit");


            for (int row = 1; row <= a; row++)
            {
                for (int column = 1; column <= b; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }



        private static void Triangle()
        {
            Console.WriteLine("Sisesta kolmnurga kahe külje mõõdud sentimeetrites:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b); // hüpotenuus
            double perimeter = a + b + c; // ümbermõõt
            double area = (a * b) / 2; // pindala

            Console.WriteLine($"Kolmnurga ümbermõõt: {perimeter} cm");
            Console.WriteLine($"Kolmnurga pindala: {area} cm²");

            
            for (int row = 1; row <= b; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int row = (int)b - 1; row >= 1; row--)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



        public static void House()
        {
            int i, j, spc, rows, k;

            Console.WriteLine("\nSisesta maja suurus: ");
            int quadrilateral = int.Parse(Console.ReadLine());

            //katus
            spc = quadrilateral + 4 - 1;

            for (i = 1; i <= quadrilateral; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                spc--;
            }

            //korrus
            int area = 0;
            int perimeter = quadrilateral * 4;
            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = " " + " *";
                        area++;
                    }
                    else
                    {
                        mark = " " + " *";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Maja pindala: {area}");
            Console.WriteLine($"Maja ümbermõõt: {perimeter}");
        }

    }
}