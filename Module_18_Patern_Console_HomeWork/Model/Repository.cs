using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Module_18_Pattern_Console_HomeWork.Model
{
     public class Repository
    {
        List<IAnimals> db;
        public Repository()
        {
            db = new List<IAnimals>();
        }
        public Repository(IEnumerable<IAnimals> Args)
        {
            db = Args.ToList<IAnimals>();
        }
        public void Add(IAnimals Animal)
        {
            db.Add(Animal);
        }
        public void PrintRepository()
        {
            foreach (var animal in db)
            {
                if (animal != null)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
        }
        static Random r;
        static Repository() { r = new Random(); }
        public List<IAnimals > GetAnimals()
        {
            return db.ToList<IAnimals>().;
        }
        public List<IAnimals> GetAnimalsConcert(string type)
        {
            return db.ToList<IAnimals>().Where(e => e.Type.Equals(type));
        }
        public static Repository GetRepository(int Count)
        {
            List<IAnimals> temp = new List<IAnimals>();
            int idCount = 0;

            for (int i = 0; i < Count; i++)
            {   
                Faker faker = new Faker();
                int countAnimals = r.Next(100, 1000);
                
                idCount++;

                switch (r.Next(3))
                {                       
                    case 1: temp.Add(new Birds($"Birds",idCount, countAnimals, $"{faker.Person.FirstName}", $"{faker.Lorem.Lines(1)}")); break;
                    case 2: temp.Add(new Mammals($"Mammals", idCount, countAnimals, $"{faker.Person.FirstName}", $"{faker.Lorem.Lines(1)}")); break;
                    default: temp.Add(new Amphibians($"Amphibians", idCount, countAnimals, $"{faker.Person.FirstName}",$"{faker.Lorem.Lines(1)}")); break;
                }
            }
            return new Repository(temp);
        }
        public void Update(IAnimals animals)
        {
            db.ToList<IAnimals>().Where(e => e.Type.Equals(type));
        }
        public void Create(IAnimals animals)
        {
            db.ToList<IAnimals>().Where(e => e.Type.Equals(type));
        }
        public void Delete(IAnimals animals)
        {
            db.ToList<IAnimals>().Where(e => e.Type.Equals(type));
        }
    }
}
