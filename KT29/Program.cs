namespace KT29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Демонстрация ковариантности интерфейса:");

            Box<Dog> dogBox = new Box<Dog>(new Dog());

            IContainer<Animal> animalContainer = dogBox;

            Animal animal = animalContainer.GetItem();

            Console.WriteLine("Тип полученного объекта: " + animal.GetType().Name);
            animal.MakeSound();

            Console.WriteLine();

            Console.WriteLine("2. Демонстрация инвариантности класса:");

            Console.WriteLine("Box<Animal> b = new Box<Dog>(new Dog());");
            Console.WriteLine("Эта строка не компилируется, поэтому она показана как текст.");
            Console.WriteLine("Класс Box<T> инвариантен.");

            Console.WriteLine();

            Console.WriteLine("3. Демонстрация ограничения ковариантности:");

            Console.WriteLine("В интерфейсе IContainer<out T> разрешено:");
            Console.WriteLine("T GetItem();");

            Console.WriteLine("Запрещено:");
            Console.WriteLine("void SetItem(T item);");
            Console.WriteLine("Параметр T нельзя использовать на входе.");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения.");
            Console.ReadKey();
        }
    }
}
