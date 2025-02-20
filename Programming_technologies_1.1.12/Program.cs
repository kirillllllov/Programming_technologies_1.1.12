using System;
namespace FirstApp
{

    public class Logic
    {
        public static string Compare(int n)
        {
            int rubles = n / 100;
            int kopecks = n % 100;
            string result;

            string rubText = GetRublesText(rubles);
            string kopText = GetKopecksText(kopecks);

            if (kopecks == 0)
                result = $"{rubles} {rubText} ровно";
            else if (rubles == 0)
                result = $"{kopecks} {kopText}";
            else
                result = $"{rubles} {rubText} {kopecks} {kopText}";
            return result;

        }
        static string GetRublesText(int rubles)
        {
            if (rubles == 0) return "";
            if (rubles % 10 == 1 && rubles % 100 != 11) return "рубль";
            if (rubles % 10 >= 2 && rubles % 10 <= 4 && (rubles % 100 < 10 || rubles % 100 >= 20)) return "рубля";
            return "рублей";
        }

        static string GetKopecksText(int kopecks)
        {
            if (kopecks == 0) return "";
            if (kopecks % 10 == 1 && kopecks % 100 != 11) return "копейка";
            if (kopecks % 10 >= 2 && kopecks % 10 <= 4 && (kopecks % 100 < 10 || kopecks % 100 >= 20)) return "копейки";
            return "копеек";
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Введите стоимость в копейках (1-9999): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 9999)
            {
                Console.WriteLine("Некорректное значение. Введите число от 1 до 9999.");
                return;
            }
            Logic.Compare(n);

        }
    }
}