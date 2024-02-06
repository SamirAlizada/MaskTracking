using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Samir";
            person1.LastName = "Alizada";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 123456789;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

     
    }
}