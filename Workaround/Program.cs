using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "ANIL FURKAN";
            person1.LastName = "YAVUZ";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }

    }

}
