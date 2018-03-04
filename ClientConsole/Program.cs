using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ClientConsole.ViewModel;
using DataAccessLayer.Fake;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Register();
            Person p = new Person();
            p.getAllPersons();
       
            IEnumerable<PersonVM> result = Mapper.Map<IEnumerable<PersonVM>>(p.getAllPersonsAsync().Result);
            foreach (var item in result)
            {
                Console.WriteLine(item.Wiek);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
            }
            PersonVM pvm = Mapper.Map<PersonVM>(p);

            IEnumerable<PersonVM> pvmx = Mapper.Map<IEnumerable<PersonVM>>(p.getAllPersons());
            foreach (var item in pvmx)
            {
                Console.WriteLine(item.Wiek);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
            }
            Console.ReadKey();


        }
        public static void Register()
        {
            Mapper.Initialize(config =>
            {
                // Mapping all 
                config.CreateMap<Person, PersonVM>();
               
            });


        }
    }
}
