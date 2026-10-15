class Program
{
    static void Main()
    {
        // Цены за один день аренды (можно менять)
        const double ценаЛыж = 500;
        const double ценаСноуборда = 700;
        const double ценаСтраховкиВДень = 100;

        // 1. Спрашиваем количество дней
        Console.Write("Введите количество дней аренды: ");
        int дни = int.Parse(Console.ReadLine());

        // 2. Спрашиваем тип снаряжения
        Console.WriteLine("Выберите снаряжение:");
        Console.WriteLine("1 - Лыжи");
        Console.WriteLine("2 - Сноуборд");
        Console.Write("Ваш выбор: ");
        int выбор = int.Parse(Console.ReadLine());

        // 3. Спрашиваем про страховку
        Console.Write("Нужна страховка? (да/нет): ");
        string страховка = Console.ReadLine();

        // 4. Считаем стоимость
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
            return; // выходим из программы
        }

        double итог = ценаВДень * дни;

        if (страховка == "да")
        {
            итог = итог + ценаСтраховкиВДень * дни;
        }

        // 5. Выводим результат
        Console.WriteLine("Итоговая сумма: " + итог + " сом.");
    }
}
