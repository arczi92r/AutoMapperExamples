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
             PersonVM pvm = Mapper.Map<PersonVM>(p);
            IEnumerable<PersonVM> pvmx = Mapper.Map<IEnumerable<PersonVM>>(p.getAllPersons());
            foreach (var item in pvmx)
            {
                Console.WriteLine(item.Age);
            }
            Console.ReadKey();
          

        }
        public static void Register()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Person , PersonVM > ();
            });


        }
    }
}
