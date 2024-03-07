using Bogus;
using Module_18_Patern_WPF_HomeWork.Model.SaveToFile.Context;
using Module_18_Pattern_Console_HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Patern_WPF_HomeWork.Model
{
    internal class FakeData
    {
        public void AddFakeData()
        {
            ContextBirds dbBirds = new ContextBirds();
            ContextMammals dbMammals = new ContextMammals();
            ContextAmphibians dbAmphibians = new ContextAmphibians();

            for (int i = 0; i < 100; i++)
            {
                Faker faker = new Faker();
                Random random = new Random();

                Birds birds = new Birds($"Birds", 0, random.Next(100, 1000), $"{faker.Person.FirstName}", $"{faker.Lorem.Lines(1)}");
                Mammals mammals = new Mammals($"Mammals", 0, random.Next(100, 1000), $"{faker.Person.FirstName}", $"{faker.Lorem.Lines(1)}");
                Amphibians amphibians = new Amphibians($"Amphibians", 0, random.Next(100, 1000), $"{faker.Person.FirstName}", $"{faker.Lorem.Lines(1)}");

                dbBirds.Birds.Add(birds);
                dbAmphibians.Amphibians.Add(amphibians);
                dbMammals.Mammals.Add(mammals);

                dbBirds.SaveChanges();
                dbAmphibians.SaveChanges();
                dbMammals.SaveChanges();
            }
        }
    }
}
