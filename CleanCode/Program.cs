using System;

namespace TemizKod
{
    /// <summary>
    /// https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
    /// </summary>
    public class Program
    {
        private const string ImagePath = @"c:\images\thumb";
        private const string IMAGE_PATH = @"c:\images\thumb";

        private string firstName;

        public string Oyunlar { get; set; }

        enum OyunTipi
        {
            Atari,
            PC,
            PS
        }

        public Program()
        {

        }

        public Program(string ifade)
        {

        }

        public Program(string ifade, string ifade2)
        {

        }

        static void Main(string[] args)
        {
            //int number = 0;    

            Person person2 = new Person();
            person2.FirstName = "Aras";
            person2.LastName = "Çalık";
            person2.CityId = 34;

            PersonManager personManager = new PersonManager();

            personManager.Add(new Person
            {
                FirstName = "Kerim",
                LastName = "Çalık",
                IdentityNumber = 1111
            });
            personManager.Add(person2);
            personManager.Add()
        }

    }

    
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public short CityId { get; set; }
    }

    public class PersonManager
    {
        public bool Add(Person person)
        {
            return true;
        }

        public bool Add(string firstName, string lastName, short cityId, long identityNumber)
        {
            return true;
        }
    }
}
