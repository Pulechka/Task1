using System;

namespace FontAdjustment
{
    [Flags]
    enum FontStyle
    {
        None = 0,
        Bold = 1,
        Italic = 2,
        Underline = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            FontStyle currentStyle = FontStyle.None;

            while (true)
            {
                Console.WriteLine($"Параметры надписи: {currentStyle}");
                Console.WriteLine("Введите:\n\t1: bold\n\t2: italic\n\t3: underline");

                int newStyle = int.Parse(Console.ReadLine());
                switch (newStyle)
                {
                    case 1:
                        currentStyle = currentStyle.HasFlag(FontStyle.Bold) ? 
                            currentStyle -= (int)FontStyle.Bold : currentStyle |= FontStyle.Bold;
                        break;
                    case 2:
                        currentStyle = currentStyle.HasFlag(FontStyle.Italic) ? 
                            currentStyle -= (int)FontStyle.Italic : currentStyle |= FontStyle.Italic;
                        break;
                    case 3:
                        currentStyle = currentStyle.HasFlag(FontStyle.Underline) ? 
                            currentStyle -= (int)FontStyle.Underline : currentStyle |= FontStyle.Underline;
                        break;
                }
                
            }
        }
    }
}
