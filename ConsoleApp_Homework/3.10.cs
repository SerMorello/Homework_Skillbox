using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 3.10.1 Приложение по определению чётного или нечётного числа

        #region

        char answer = 'y';
        while (answer == 'y')
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
            Console.WriteLine("Eще число? y/n");
            answer = char.Parse(Console.ReadLine());
        }
        Console.ReadKey();

        #endregion

        // 3.10.2(2) Программа подсчёта суммы карт в игре «21»

        #region

        int sumCards = 0;

        Console.WriteLine("Введите количество карт на руках");
        int quantityCards = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номинал карт");
        Console.WriteLine("2-10, 'J', 'Q', 'K', 'T'");

        for (int i = 0; i < quantityCards; i++)
        {

            var card = Console.ReadLine();
            int valueCard = 0;
            if (card[0] >= '2' && card[0] <= '9')
            {
                valueCard = Convert.ToInt32(card);
            }
            else
            {
                valueCard = 10;
            }
            sumCards = sumCards + valueCard;
        }
        Console.WriteLine(sumCards);
        Console.ReadKey();

        #endregion

        // 3.10.2(1) Программа подсчёта суммы карт в игре «21»

        #region

        int sumCards = 0;

        Console.WriteLine("Введите количество карт на руках");
        int quantityCards = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номинал карт");
        Console.WriteLine("2-10, 'J', 'Q', 'K', 'T'");

        for (int i = 0; i < quantityCards; i++)
        {

            var card = Console.ReadLine();

            switch (card)
            {
                case "2":
                    sumCards = sumCards + 2;
                    break;
                case "3":
                    sumCards = sumCards + 3;
                    break;
                case "4":
                    sumCards = sumCards + 4;
                    break;
                case "5":
                    sumCards = sumCards + 5;
                    break;
                case "6":
                    sumCards = sumCards + 6;
                    break;
                case "7":
                    sumCards = sumCards + 7;
                    break;
                case "8":
                    sumCards = sumCards + 8;
                    break;
                case "9":
                    sumCards = sumCards + 9;
                    break;
                case "10":
                    sumCards = sumCards + 10;
                    break;
                case "J":
                    sumCards = sumCards + 10;
                    break;
                case "Q":
                    sumCards = sumCards + 10;
                    break;
                case "K":
                    sumCards = sumCards + 10;
                    break;
                case "T":
                    sumCards = sumCards + 10;
                    break;
            }
        }

        Console.WriteLine(sumCards);
        Console.ReadKey();

        #endregion

        // 3.10.3 Проверка простого числа

        #region

        bool simpleNumber = true;
        Console.WriteLine("Введите число для проверки");
        int n = Convert.ToInt32(Console.ReadLine());
        int cnt = 1;

        while (cnt < n - 1)
        {
            cnt++;

            if (n % cnt == 0)
            {
                simpleNumber = false;
            }
        }

        if (simpleNumber == true)
        {
            Console.WriteLine("Введенное число простое");
        }
        else
        {
            Console.WriteLine("Введенное число не является простым");
        }

        #endregion

        // 3.10.4 Наименьший элемент в последовательности

        #region

        int min = int.MaxValue;

        Console.WriteLine("Введите количество элементов последовательности");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (min > num)
            {
                min = num;
            }
        }

        Console.WriteLine($"Минимальное число из последовательности: {min}");

        #endregion

        // 3.10.5 Игра «Угадай число»

        #region

        Console.WriteLine("Введите число верхней границы диапазона");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Попробуйте угадать какое число я загадал, а если надоест нажмите кнопку пробел");

        Random rndm = new Random();
        int num = rndm.Next(0, n);

        while (true)
        {
            var userAnsw = Console.ReadLine();

            if (userAnsw == " ")
            {
                Console.WriteLine("Всего хорошего");
                Console.WriteLine($"Мое число было {num}");
                break;
            }
            else
            {
                int userNum = Convert.ToInt32(userAnsw);

                if (userNum > num)
                {
                    Console.WriteLine("Ваше число больше загаданного");
                }
                else if (userNum < num)
                {
                    Console.WriteLine("Ваше число меньше загаданного");
                }
                else if (userNum == num)
                {
                    Console.WriteLine("Поздравляю, вы выиграли");
                    break;
                }
            }
        }

        #endregion

    }
}