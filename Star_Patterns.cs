using System;

namespace StarPatterns
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void NewLine() => Console.WriteLine();

        public static void Rectangle(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < m - 2; i++)
            {
                Star();
                for (int j = 0; j < n - 2; j++)
                {
                    Space();
                }
                StarLn();
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }
        
        public static void MirrorZ(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }

            NewLine();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }

        public static void LetterZ(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < n - i - 2; j++)
                {
                    Space();
                }
                StarLn();
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }

        public static void Hourglass(int n)
        {
            if (n % 2 == 0)
            {
                //sufit
                for (int i = 0; i < n; i++)
                {
                    Star();
                }
                NewLine();

                //pomiedzy góra
                for (int i = 1; i <= n / 3; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < n - 2 - (2 * i); j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //gwiazdka srodek
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < n / 2 - 1; j++)
                    {
                        Space();
                    }
                    Star();
                    StarLn();
                }

                //pomiedzy dół
                for (int i = 1; i <= n / 3; i++)
                {
                    for (int j = i; j < n / 2 - 1; j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < i * 2; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                    //podstawa
                    for (int i = 0; i < n; i++)
                {
                    Star();
                }
                NewLine();
            }
            else if (n % 2 == 1)
            {
                //sufit
                for (int i = 0; i < n; i++)
                {
                    Star();
                }
                NewLine();


                // od sufitu do środka
                for (int i = 1; i < n / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < n - 2 - (2 * i); j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //gwiazdka srodek
                for (int i = 0; i < n / 2; i++)
                {
                    Space();
                }
                StarLn();

                //od środka do podłogi
                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    for (int j = i; j < (n / 2); j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < (2 * i) - 1; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //podłoga
                for (int i = 0; i < n; i++)
                {
                    Star();
                }
            }
        }

        public static void LetterX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");

            if (n % 2 == 0)
            {
                //sufit
                Star();
                for (int i = 0; i < n - 2; i++)
                {
                    Space();
                }
                StarLn();

                //pomiedzy góra
                for (int i = 1; i <= n / 3; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < n - 2 - (2 * i); j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //gwiazdka srodek
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < n / 2 - 1; j++)
                    {
                        Space();
                    }
                    Star();
                    StarLn();
                }

                //pomiedzy dół
                for (int i = 1; i <= n / 3; i++)
                {
                    for (int j = i; j < n / 2 - 1; j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < i * 2; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //podstawa
                Star();
                for (int i = 0; i < n - 2; i++)
                {
                    Space();
                }
                StarLn();
            }
            if (n % 2 == 1)
            {
                //góra
                Star();
                for (int i = 0; i < n - 2; i++)
                {
                    Space();
                }
                StarLn();

                // od góry do środka
                for (int i = 1; i < n / 2; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < n - 2 - (2 * i); j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //gwiazdka srodek
                for (int i = 0; i < n / 2; i++)
                {
                    Space();
                }
                StarLn();

                //od środka do dołu
                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    for (int j = i; j < (n / 2); j++)
                    {
                        Space();
                    }
                    Star();
                    for (int j = 0; j < (2 * i) - 1; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //dół
                Star();
                for (int i = 0; i < n - 2; i++)
                {
                    Space();
                }
                StarLn();
            }
        }

        public static void TriangleEmptyUp(int n)
        {
            if (n % 2 == 0)
            {
                n = n - 1;
            }
            //gwiazdka
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();

            //miedzy gwiazdką a podłogą
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                for (int j = i; j < (n / 2); j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //podłoga
            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }

        public static void TriangleEmptyDown(int n)
        {
            if (n % 2 == 0)
            {
                n = n - 1;
            }
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < n - 4 - (2 * i); j++)
                {
                    Space();
                }
                StarLn();
            }

            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            Star();
        }

        public static void TriangleFillDown(int n)
        {
            if (n % 2 == 0)
            {
                n = n - 1;
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                for (int j = 0; j < n - 2 - (i * 2); j++)
                {
                    Star();
                }
                NewLine();
            }
        }
        
        public static void DiamondEmpty_Fill(int n)
        {
            if (n % 2 == 0)
            {
                n = n - 1;
            }
            //górna gwiazdka
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();

            //góra pusta
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                for (int j = i; j < (n / 2); j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < (2 * i) - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //środkowa kreska
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //dół pełny
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                for (int j = 0; j < n - 2 - (i * 2); j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void DiamondFill_Empty(int n)
        {
            if (n % 2 == 0)
            {
                n = n - 1;
            }
            //górna gwiazdka
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();

            //trójkąt pełny
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                for (int j = i; j < n / 2; j++)
                {
                    Space();
                }
                for (int j = 0; j < 1 + (2 * i); j++)
                {
                    Star();
                }
                NewLine();
            }

            //środek
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //dół pusty
            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < n - 4 - (2 * i); j++)
                {
                    Space();
                }
                StarLn();
            }

            //dolna gwiazdka
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();
        }

        public static void DiamondFill_Fill(int n)
        {
            if (n % 2 == 0)
            {
                n = n - 1;
            }
            //górna gwiazdka
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();

            //góra reszta
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                for (int j = i; j < n / 2; j++)
                {
                    Space();
                }
                for (int j = 0; j < 1 + (2 * i); j++)
                {
                    Star();
                }
                NewLine();
            }

            //środek
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //dół cały
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Space();
                }
                for (int j = 0; j < n - 2 - (i * 2); j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void LetterN(int n)
        {
            //sufit
            Star();
            for (int i = 0; i < n - 2; i++)
            {
                Space();
            }
            StarLn();

            //miedzy sufitem i podłogą
            for (int i = 0; i < n - 2; i++)
            {
                Star();
                for (int j = 0; j < i; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < n - 3 - i; j++)
                {
                    Space();
                }
                StarLn();
            }

            //podłoga
            Star();
            for (int i = 0; i < n - 2; i++)
            {
                Space();
            }
            StarLn();
        }

        public static void reverseN(int n)
        {
            //sufit
            Star();
            for (int i = 0; i < n - 2; i++)
            {
                Space();
            }
            StarLn();

            //miedzy sufitem i podłogą
            for (int i = 1; i < n - 1; i++)
            {
                Star();
                for (int j = 0; j < n - i - 2; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < i - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //podłoga
            Star();
            for (int i = 0; i < n - 2; i++)
            {
                Space();
            }
            StarLn();
        }

        public static void Chessboard(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Star();
                    Space();
                }
                NewLine();
                for (int j = 0; j < n / 2; j++)
                {
                    Space();
                    Star();
                }
                NewLine();
            }
        }

        public static void Lettice1(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Star();
                    Space();
                }
                NewLine();
                for (int j = 0; j < n - 1; j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void Lettice2(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1; j++)
                {
                    Space();
                    Star();
                }
                NewLine();
                for (int j = 0; j < n - 1; j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void LetterK(int n)
        {
            if (n % 2 == 1)
            {
                //góra
                for (int i = 1; i <= n / 2; i++)
                {
                    Star();
                    for (int j = i; j < n / 2 + 1; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //środek
                for (int i = 0; i < 2; i++)
                {
                    Star();
                }
                NewLine();

                //dół
                for (int i = 0; i < n / 2; i++)
                {
                    Star();
                    for (int j = 0; j < i + 1; j++)
                    {
                        Space();
                    }
                    StarLn();
                }
            }
            else if (n % 2 == 0)
            {
                //góra
                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Star();
                    for (int j = i; j < n / 2; j++)
                    {
                        Space();
                    }
                    StarLn();
                }

                //środek
                for (int i = 0; i < 2; i++)
                {
                    Star();
                    Star();
                    NewLine();
                }

                //dół
                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Star();
                    for (int j = 0; j < i; j++)
                    {
                        Space();
                    }
                    StarLn();
                }
            }
        }

        public static void Triangle1(int n)
        {
            //podstawa
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //pomiedzy
            for (int i = 1; i <= n - 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < n - i - 2; j++)
                {
                    Space();
                }
                StarLn();
            }

            //gwiazdka solo
            for (int i = 0; i < n - 1; i++)
            {
                Space();
            }
            StarLn();
        }

        public static void Triangle2(int n)
        {
            //gwiazdka solo
            for (int i = 0; i < n - 1; i++)
            {
                Space();
            }
            StarLn();

            //pomiedzy
            for (int i = 1; i <= n - 2; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < i - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //podstawa
            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }

        public static void Triangle3(int n)
        {
            //podstawa
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //środek
            for (int i = 1; i <= n - 2; i++)
            {
                Star();
                for (int j = 0; j < n - i - 2; j++)
                {
                    Space();
                }
                StarLn();
            }

            //gwiazdka
            Star();
        }

        public static void Triangle4(int n)
        {
            //gwiazdka
            StarLn();

            //pomiedzy
            for (int i = 1; i <= n - 2; i++)
            {
                Star();
                for (int j = 0; j < i - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //podstawa
            for (int i = 0; i < n; i++)
            {
                Star();
            }
        }

        public static void LetterS(int n)
        {
            //góra
            Space();
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
            NewLine();

            //od góry do środka
            for (int i = 0; i < 2; i++)
            {
                StarLn();
            }

            //środek
            Space();
            for (int i = 0; i < n - 2; i++)
            {
                Star();
            }
            NewLine();

            //od środka do dołu
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //dół
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }
        }

        public static void Reverse7(int n)
        {
            if (n < 3)
            {
                throw new ArgumentOutOfRangeException("");
            }
            for (int i = 1; i <= n; i++)
            {
                Star();
            }
            NewLine();
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Space();
                }
                StarLn();
            }
        }

        public static void Number7(int n)
        {
            //sufit
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //reszta
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Space();
                }
                StarLn();
            }
        }

        public static void Number4(int n)
        {
            //gwiazdka solo góra
            for (int i = 0; i < n - 4; i++)
            {
                Space();
            }
            StarLn();

            //pomiedzy górą a środkiem
            for (int i = 1; i <= n - 5; i++)
            {
                for (int j = 0; j < n - i - 4; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < i - 1; j++)
                {
                    Space();
                }
                StarLn();
            }

            //środek
            for (int i = 0; i < n - 3; i++)
            {
                Star();
            }
            NewLine();

            //dół
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n - 4; j++)
                {
                    Space();
                }
                StarLn();
            }
        }

        //Triangles filled with size of int n
        public static void TriangleUpLeft_Right(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void TriangleUpRight_Left(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < (n / 2) + 3; j++)
                {
                    Space();
                }
                for (int j = 0; j < i; j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void TriangleDownLeft_Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Space();
                }
                for (int j = 0; j < n - i ; j++)
                {
                    Star();
                }
                NewLine();
            }
        }

        public static void TriangleDownRight_Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Star();
                }
                NewLine();
            }
        }
    }
}