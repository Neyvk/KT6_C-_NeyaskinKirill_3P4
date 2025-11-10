using System;

namespace EnumExamples
{
    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta
    }

    class Program
    {

        static string GetColorHex(Color color)
        {
            return color switch
            {
                Color.Red => "#FF0000",
                Color.Green => "#00FF00",
                Color.Blue => "#0000FF",
                Color.Yellow => "#FFFF00",
                Color.Cyan => "#00FFFF",
                Color.Magenta => "#FF00FF",
                _ => "#000000"
            };
        }
        static void Main()
        {
            Console.Write("Цвет: ");
            str = Console.ReadLine();
            if (Enum.TryParse(str, true, out Color color))
            {
                string result =  GetColorHex(color);
                Console.WriteLine(result);
            }
        }


    }
}
