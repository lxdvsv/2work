namespace _2_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод данных о продукте: ");

            Console.Write("Ввод названия продукта: ");
            string productName = Console.ReadLine().Trim().ToUpper();

            Console.Write("Введите количество продукта: ");
            double quantity = double.Parse(Console.ReadLine().Replace(',', '.'));

            Console.Write("Ввод единицы измерения: (шт., кг, литры: ): ");
            string unit = Console.ReadLine().Trim().ToLower();

            Console.Write("Ввод цены продукта: ");
            decimal price = decimal.Parse(Console.ReadLine().Replace(',', '.'));

            Console.Clear();

            Console.WriteLine("\nВаши данные: ");
            Console.WriteLine("Название продукта: " + productName);
            Console.WriteLine("Количество продукта: " + quantity);
            Console.WriteLine("Единица измерения: " + unit);
            Console.WriteLine("Цена продукта: " + price);
            Console.WriteLine("\n\"Путь самурая — это утонченная гармония мудрости и мужества, где каждый момент жизни — как удар меча: быстрый, точный и наполненный целеустремленностью.");
        }
    }
}
