using System;

namespace animal
{
    class Program
    {
        interface IAnimal
        {
            string Type { get; }
            void MakeSound();
        }

        class Pig : IAnimal
        {
            public string Type => "Mamífero";

            public void MakeSound()
            {
                Console.WriteLine("El cerdo hace oing");
            }
        }

        class Dog : IAnimal
        {
            public string Type => "Mamífero";

            public void MakeSound()
            {
                Console.WriteLine("El perro hace guau guau");
            }
        }

        class Chicken : IAnimal
        {
            public string Type => "Ave";

            public void MakeSound()
            {
                Console.WriteLine("El pollo hace pio pio");
            }
        }

        class Cat : IAnimal
        {
            public string Type => "Mamífero";

            public void MakeSound()
            {
                Console.WriteLine("El gato hace miau miau");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------ANIMALES--------");

            Pig cerdo1 = new Pig();
            Console.WriteLine($"Tipo: {cerdo1.Type}");
            cerdo1.MakeSound();
            Sleep();

            Dog perro1 = new Dog();
            Console.WriteLine($"Tipo: {perro1.Type}");
            perro1.MakeSound();
            Sleep();

            Chicken pollo1 = new Chicken();
            Console.WriteLine($"Tipo: {pollo1.Type}");
            pollo1.MakeSound();
            Sleep();

            Cat gato1 = new Cat();
            Console.WriteLine($"Tipo: {gato1.Type}");
            gato1.MakeSound();
            Sleep();
        }

        static void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}


