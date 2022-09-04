/*
*/
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace Seminar002
{
    class Program
    {
        static void Main(string[] args)
        {
            // using (TestDBContext db = new TestDBContext())
            // {
            //     // создаем два объекта User
            //     User user1 = new User { Id = 0, Name = "Tom", Age = 33 };
            //     User user2 = new User { Id = 1, Name = "Alice", Age = 26 };

            //     // добавляем их в бд
            //     db.Users.AddRange(user1, user2);
            //     db.SaveChanges();
            // }
            // // получение данных
            // using (TestDBContext db = new TestDBContext())
            // {
            //     // получаем объекты из бд и выводим на консоль
            //     var users = db.Users.ToList();
            //     Console.WriteLine("Users list:");
            //     foreach (User u in users)
            //     {
            //         Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
            //     }
            // }
            // // добавление данных
            // using (ApplicationContext db = new ApplicationContext())
            // {
            //     // создаем два объекта User
            //     Persons person = new Persons(0,
            //                                  "Иванов И. И.", 
            //                                  DateOnly.Parse("1990-02-12"),
            //                                  true,
            //                                  126,
            //                                  "интернет",
            //                                  "Можга",
            //                                  "Работа");
 
            //     // добавляем их в бд
            //     db.persons.AddRange(person);
            //     db.SaveChanges();
            // }

            // добавление данных
            using (TestDBContext db = new TestDBContext())
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                    BadDataFound = null,
                };
                // создаем два объекта User
                using (var reader = new StreamReader("output.csv", Encoding.Default))
                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<Person>();
                    Console.WriteLine("Persons list:");
                    
                    // добавляем их в бд
                    db.Persons.AddRange(records);
                    db.SaveChanges();
                }
            }
            // получение данных
            using (TestDBContext db = new TestDBContext())
            {
                // получаем объекты из бд и выводим на консоль
                var persons = db.Persons.ToList();
                Console.WriteLine("Persons list:");
                foreach (Person u in persons)
                {
                    Console.WriteLine($"| {u.Id} | "+
                                      $"{u.PersonFullName} | "+
                                      $"{u.PersonBirthday} | "+
                                      $"{u.PersonStatus} | "+
                                      $"{u.PersonPhone} | "+
                                      $"{u.PersonComment} | "+
                                      $"{u.PersonAddress} | "+
                                      $"{u.PersonGroup} |");
                }
            }
        }
    }
}