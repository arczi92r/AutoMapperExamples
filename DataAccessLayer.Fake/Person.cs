using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccessLayer.Fake
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        public IEnumerable<Person> getAllPersons()
        {
            List<Person> person = new List<Person>();

            Person p1 = new Person() { Age = 12, Name = "Arek1", Surname = "kjaskdajskd" };
            Person p2 = new Person() { Age = 14, Name = "Arek2", Surname = "fdgf" };
            Person p3 = new Person() { Age = 123, Name = "Arek3", Surname = "kfuyi" };
            Person p4 = new Person() { Age = 19, Name = "Arek4", Surname = "gjghj" };
            Person p5 = new Person() { Age = 17, Name = "Arek5", Surname = "ddasdsad" };

            person.Add(p1);
            person.Add(p2);
            person.Add(p3);
            person.Add(p4);
            person.Add(p5);

            return person.AsEnumerable();

        }
        public async Task<IEnumerable<Person>> getAllPersonsAsync()
        {
            List<Person> person = new List<Person>();

            Person p1 = new Person() { Age = 12, Name = "Arek1", Surname = "kjaskdajskd" };
            Person p2 = new Person() { Age = 14, Name = "Arek2", Surname = "fdgf" };
            Person p3 = new Person() { Age = 123, Name = "Arek3", Surname = "kfuyi" };
            Person p4 = new Person() { Age = 19, Name = "Arek4", Surname = "gjghj" };
            Person p5 = new Person() { Age = 17, Name = "Arek5", Surname = "ddasdsad" };

            person.Add(p1);
            person.Add(p2);
            person.Add(p3);
            person.Add(p4);
            person.Add(p5);

            return person.AsEnumerable();
        }
    }


}
