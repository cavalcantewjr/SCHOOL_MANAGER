﻿using Domain.Entities;
using Infrastructure.Data;
using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
                School school = new School
                {
                    SchoolName = "teste",
                    Adress = "Rua teste, 02"
                };
                SchoolDAL schoolDAL = new SchoolDAL();
                Console.WriteLine($"Registrando escola {school}");
                schoolDAL.RegisterSchool(school);

            
        }
    }
}
