class Program
{
    static void Main()
    {
        const double ценаЛыж = 500;
        const double ценаСноуборда = 700;
        const double ценаСтраховкиВДень = 100;

        Console.Write("Введите количество дней аренды: ");
        int дни = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите снаряжение:");
        Console.WriteLine("1 - Лыжи");
        Console.WriteLine("2 - Сноуборд");
        Console.Write("Ваш выбор: ");
        int выбор = int.Parse(Console.ReadLine());

        Console.Write("Нужна страховка? (да/нет): ");
        string страховка = Console.ReadLine();

        double ценаВДень;

        if (выбор == 1)
        {
            ценаВДень = ценаЛыж;
        }
        else if (выбор == 2)
        {
            ценаВДень = ценаСноуборда;
        }
        else
        {
            Console.WriteLine("Ошибка: такого снаряжения нет!");
            return;
        }

        double итог = ценаВДень * дни;

        if (страховка == "да")
        {
            итог = итог + ценаСтраховкиВДень * дни;
        }

        
        Console.WriteLine("Итоговая сумма: " + итог + " сом.");
    }
}
