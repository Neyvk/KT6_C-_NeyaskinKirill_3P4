using System;

namespace EnumExamples
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {

        static void PrintDayInRussian(DayOfWeek day)
        {
            string dayInRussian = day switch
            {
                DayOfWeek.Monday => "Понедельник",
                DayOfWeek.Tuesday => "Вторник",
                DayOfWeek.Wednesday => "Среда",
                DayOfWeek.Thursday => "Четверг",
                DayOfWeek.Friday => "Пятница",
                DayOfWeek.Saturday => "Суббота",
                DayOfWeek.Sunday => "Воскресенье",
                _ => "Неизвестный день"
            };

            Console.WriteLine($"На русском: {dayInRussian}");
        }
      
        }
        static void Main()
        {
            Console.Write("День недели: ");
            string str = Console.ReadLine();
            if (Enum.TryParse(str, true, out DayOfWeek day))
            {
                PrintDayInRussian(day);
            }
        }


    }
}
