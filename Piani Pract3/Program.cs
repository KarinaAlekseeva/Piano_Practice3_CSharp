namespace Piani_Pract3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите F3 или F4. Для смены октавы нажмите `(там, где буква ё), затем F3 или F4");

            Console.WriteLine("qwert - чёрные клавиши, asdfghj - белые клавиши");

            char klavisha = '1';

            ConsoleKeyInfo oct = Console.ReadKey();

            int[] octava = new int[] { };

            while (klavisha != ((char)ConsoleKey.Escape))
            {
                octava = Octavi(oct);

                klavisha = Console.ReadKey(true).KeyChar;

                switch (klavisha)
                {
                    case 'q':
                        beep(octava, 1);
                        break;

                    case 'w':
                        beep(octava, 3);
                        break;

                    case 'e':
                        beep(octava, 6);
                        break;

                    case 'r':
                        beep(octava, 8);
                        break;

                    case 't':
                        beep(octava, 10);
                        break;

                    case 'a':
                        beep(octava, 0);
                        break;

                    case 's':
                        beep(octava, 2);
                        break;

                    case 'd':
                        beep(octava, 4);
                        break;

                    case 'f':
                        beep(octava, 5);
                        break;

                    case 'g':
                        beep(octava, 7);
                        break;

                    case 'h':
                        beep(octava, 9);
                        break;

                    case 'j':
                        beep(octava, 11);
                        break;
                    case '`':
                        oct = Console.ReadKey();
                        break;
                }
            }
        }
        static void beep(int[] oct, int numkla)
        {
            Console.Beep(oct[numkla], 250);
        }

        static int[] Octavi(ConsoleKeyInfo oct)
        {
            if (oct.Key == ConsoleKey.F3)
            {
                int[] ThirdOctava = new[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
                return ThirdOctava;
            }
            else if (oct.Key == ConsoleKey.F4)
            {
                int[] FourOctava = new[] { 262, 277, 294, 311, 330, 350, 370, 392, 415, 440, 466, 494 };
                return FourOctava;
            }
            else
                return null;

        }
    }
}