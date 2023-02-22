internal class Program
{
    private static void Main(string[] args)
    {
        #region

        //char answer = 'y';
        //while (answer == 'y')
        //{
        //    Console.WriteLine("Введите число");
        //    int num = int.Parse(Console.ReadLine());
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine("Число четное");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Число не четное");
        //    }
        //    Console.WriteLine("Eще число? y/n");
        //    answer = char.Parse(Console.ReadLine());
        //}
        //Console.ReadKey();

        #endregion

        #region

        int sumCards = 0;

        Console.WriteLine("Введите количество карт на руках");
        int quantityCards = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номинал карт");
        Console.WriteLine("2-10, 'J', 'Q', 'K', 'T'");

        for (int i = 0; i < quantityCards; i++)
        {

            var Card = Console.ReadLine();
            int valueCard = 0;
            if (valueCard >= '0' && valueCard <= '9' )
            {
                valueCard = Convert.ToInt32(Card);
            }
            else
            {
                valueCard = 10;
            }
            sumCards = sumCards + valueCard;
            //switch (valueCard)
            //{
            //    case valueCard
            //        sumCards = sumCards + valueCard;
            //        break;

            //}
        }
        Console.WriteLine(sumCards);
        Console.ReadKey();

        #endregion
    }
}