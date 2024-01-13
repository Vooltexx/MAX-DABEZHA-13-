using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0001
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа, ввести с экрана вариант ответа. Программа должна оценить ответ и в случае неправильного ответа написать правильный.
            //Console.WriteLine("1. Вопрос?");
            //Console.WriteLine("a) Ответ 1");
            //Console.WriteLine("b) Ответ 2");
            //Console.WriteLine("c) Ответ 3");
            //Console.Write("Введите вариант ответа (a, b, c): ");
            //string userAnswer = Console.ReadLine();
            //if (userAnswer.ToLower() == "a")
            //{
            //    Console.WriteLine("Правильный ответ!");
            //}
            //else
            //{
            //    Console.WriteLine("Неправильный ответ. Правильный ответ: a) Ответ 1");
            //}
            //Console.ReadKey();

            //2.Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20 % скидка.Ввести продолжительность разговора и день недели(цифра от 1 до 7).
            //Console.Write("Введите продолжительность разговора (в минутах): ");
            //int duration = int.Parse(Console.ReadLine());
            //Console.Write("Введите день недели (цифра от 1 до 7): ");
            //int dayOfWeek = int.Parse(Console.ReadLine());
            //double costPerMinute = 0.1;
            //double totalCost;

            //if (dayOfWeek == 6 || dayOfWeek == 7)
            //{
            //    totalCost = duration * costPerMinute * 0.8;
            //}
            //else
            //{
            //    totalCost = duration * costPerMinute;
            //}

            //Console.WriteLine($"Стоимость переговоров: {totalCost} руб.");
            //Console.ReadKey();

            //3.Написать программу для определения времени суток по данному текущему времени и вывести сообщение(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).
            //Console.Write("Введите текущее время (часы от 0 до 23): ");
            //int currentTime = int.Parse(Console.ReadLine());

            //string timeOfDay;

            //if (currentTime >= 6 && currentTime < 12)
            //{
            //    timeOfDay = "утро";
            //}
            //else if (currentTime >= 12 && currentTime < 18)
            //{
            //    timeOfDay = "день";
            //}
            //else if (currentTime >= 18 && currentTime < 24)
            //{
            //    timeOfDay = "вечер";
            //}
            //else
            //{
            //    timeOfDay = "ночь";
            //}

            //Console.WriteLine($"Текущее время суток: {timeOfDay}");
            //Console.ReadKey();

            //4.Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому, умноженным на коэффициент стажа работы по специальности, который равен: нет стажа – 1, меньше 2 лет – 13, от 2 до 5 лет – 16.Составить программу расчета рейтинга при заданном среднем балле диплома(от 3 до 5) и вывести сообщение о приеме в магистратуру при проходном балле 45.
            //Console.Write("Введите средний балл диплома (от 3 до 5): ");
            //   double averageGrade = double.Parse(Console.ReadLine());

            //   Console.Write("Введите стаж работы по специальности (в годах): ");
            //   int workExperience = int.Parse(Console.ReadLine());

            //   double experienceCoefficient;

            //   if (workExperience < 2)
            //   {
            //       experienceCoefficient = 1;
            //   }
            //   else if (workExperience >= 2 && workExperience <= 5)
            //   {
            //       experienceCoefficient = 1.3;
            //   }
            //   else
            //   {
            //       experienceCoefficient = 1; 
            //   }

            //   double rating = averageGrade * experienceCoefficient;

            //   Console.WriteLine($"Рейтинг бакалавра: {rating}");

            //   if (rating >= 45)
            //   {
            //       Console.WriteLine("Поздравляем! Вы приняты в магистратуру.");
            //   }
            //   else
            //   {
            //       Console.WriteLine("К сожалению, рейтинг не соответствует проходному баллу.");
            //   }
            //   Console.ReadKey();

            //5.Написать программу , которая по дате рождения(день d месяц n) определяет знак Зодиака: с 22 марта по 21 апреля - Овен(4); с 22 апреля по 21 мая - Телец(5); с 22 мая по 21 июня - Близнецы(6); с 22 июня по 21 июля - Рак(7); с 22 июля по 21 августа - Лев(8); с 22 августа по 21 сентября - Дева(9); 22 сентября по 21 октября - Весы(10); с 22 октября по 21 ноября - Скорпион(11); с 22 ноября по 21 декабря - Стрелец(12); с 22 декабря по 21 января - Козерог(1); 22 января по 21 февраля - Водолей(2); с 22 февраля по 21 марта - Рыбы(3).
            //Console.Write("Введите день рождения (число): ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Введите месяц рождения (число): ");
            //int month = int.Parse(Console.ReadLine());

            //int zodiacSign = (month % 12 + (day >= 22 ? 1 : 0)) % 12 + 1;

            //Console.WriteLine($"Знак Зодиака: {zodiacSign}");
            //Console.ReadKey();

            //6.Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка" в правильной форме.Например, 1 копейка, 5 копеек, 42 копейки.
            //Console.Write("Введите число от 1 до 99: ");
            //int number = int.Parse(Console.ReadLine());
            //string form;

            //if (number % 10 == 1 && number != 11)
            //{
            //    form = "копейка";
            //}
            //else if ((number % 10 >= 2 && number % 10 <= 4) && !(number >= 12 && number <= 14))
            //{
            //    form = "копейки";
            //}
            //else
            //{
            //    form = "копеек";
            //}

            //Console.WriteLine($"{number} {form}");
            //Console.ReadKey();

            //7.Написать программу, которая после введенного с клавиатуры числа в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.
            Console.Write("Введите число от 1 до 99: ");
            int number = int.Parse(Console.ReadLine());

            string rubleWord;

            if (number % 10 == 1 && number != 11)
            {
                rubleWord = "рубль";
            }
            else if ((number % 10 >= 2 && number % 10 <= 4) && !(number >= 12 && number <= 14))
            {
                rubleWord = "рубля";
            }
            else
            {
                rubleWord = "рублей";
            }

            Console.WriteLine($"Сумма: {number} {rubleWord}");
            Console.ReadKey();
        }
    }
}
