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

        interface IAnimalId
        {
            void Id();
            void Name();
            void Age();
        }

        class Pig : IAnimal, IAnimalId
        {
            public string Type => "Mamífero";

            public void MakeSound()
            {
                Console.WriteLine("El cerdo hace oing");
            }

            public void Id()
            {
                Console.WriteLine("ID del cerdo: 1");
            }

            public void Name()
            {
                Console.WriteLine("Nombre del cerdo: Porky");
            }

            public void Age()
            {
                Console.WriteLine("Edad del cerdo: 2 años");
            }
        }

        class Dog : IAnimal, IAnimalId
        {
            public string Type => "Mamífero";

            public void MakeSound()
            {
                Console.WriteLine("El perro hace guau guau");
            }

            public void Id()
            {
                Console.WriteLine("ID del perro: 2");
            }

            public void Name()
            {
                Console.WriteLine("Nombre del perro: Firulais");
            }

            public void Age()
            {
                Console.WriteLine("Edad del perro: 3 años");
            }
        }

        class Chicken : IAnimal, IAnimalId
        {
            public string Type => "Ave";

            public void MakeSound()
            {
                Console.WriteLine("El pollo hace pio pio");
            }

            public void Id()
            {
                Console.WriteLine("ID del pollo: 3");
            }

            public void Name()
            {
                Console.WriteLine("Nombre del pollo: Chicken little");
            }

            public void Age()
            {
                Console.WriteLine("Edad del pollo: 1 año");
            }
        }

        class Cat : IAnimal, IAnimalId
        {
            public string Type => "Mamífero";

            public void MakeSound()
            {
                Console.WriteLine("El gato hace miau miau");
            }

            public void Id()
            {
                Console.WriteLine("ID del gato: 4");
            }

            public void Name()
            {
                Console.WriteLine("Nombre del gato: michi");
            }

            public void Age()
            {
                Console.WriteLine("Edad del gato: 4 años");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------ANIMALES--------");

            Pig cerdo1 = new Pig();
            Console.WriteLine($"Tipo: {cerdo1.Type}");
            cerdo1.MakeSound();
            Sleep();
            cerdo1.Id();
            cerdo1.Name();
            cerdo1.Age();
            

            Dog perro1 = new Dog();
            Console.WriteLine($"Tipo: {perro1.Type}");
            perro1.MakeSound();
            Sleep();
            perro1.Id();
            perro1.Name();
            perro1.Age();
            

            Chicken pollo1 = new Chicken();
            Console.WriteLine($"Tipo: {pollo1.Type}");
            pollo1.MakeSound();
            Sleep();
            pollo1.Id();
            pollo1.Name();
            pollo1.Age();
            

            Cat gato1 = new Cat();
            Console.WriteLine($"Tipo: {gato1.Type}");
            gato1.MakeSound();
            Sleep();
            gato1.Id();
            gato1.Name();
            gato1.Age();
            
        }

        static void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}



