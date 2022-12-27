using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    public abstract class Pets
    {
        public string Korm;
        public string Age;
        public string Place;
        public string Individ;

      
    }
    class Mlek : Pets 
    {
        public string Lai;
        public void Print()
        {
            Console.WriteLine("dwqe");
            Console.WriteLine($"Korm: {Korm}");
        }


    }
  
    class Pres: Pets { }
 
    class Bird : Pets { }
    class Fish: Pets { }
    class Dog: Mlek { public string VolumeLai; }
    class Cat: Mlek { }
    class Krok: Pres { }
    class Vorobey: Bird { }
    class Shuka: Fish { }





    class Program 
    {
        static Mlek AboutDog()
        {
            var dog = new Dog();

            dog.Korm = "Felex";
            dog.Age = "2";
            dog.Place = "House";
            dog.Individ = "Crazy";
            return dog;
        }
        static void Print(Mlek dog)
        {
            Console.WriteLine("dwqe");
            Console.WriteLine($"Korm: {dog.Korm}");
        }
        static Cat Aboutcat()
        {
            var cat = new Cat();

            cat.Korm = "eera";
            cat.Age = "2";
            cat.Place = "Room";
            cat.Individ = "fail";

            return new Cat();
        }


        static void Main(string[] args)
        {
            

        }
    
    
    
    
    }

}












