﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> people = new List<Person>();

            Person mark = new Person("Mark", 46, "male");
            people.Add(mark);
            Person jane = new Person();
            people.Add(jane);
            Student john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            Student student = new Student();
            people.Add(student);
            Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior");
            people.Add(gandhi);
            Mentor mentor = new Mentor();
            people.Add(mentor);
            Sponsor sponsor = new Sponsor();
            people.Add(sponsor);
            Sponsor elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (Person person in people)
            {
                person.Introduce();
                person.GetGoal();
            }
            Console.ReadLine();

        }
    }
}

























// Green Fox inheritance exercise

//Person

//Create a Person class with the following fields:

//name: the name of the person
//age: the age of the person(whole number)
//gender: the gender of the person(male / female)
//And the following methods:

//Introduce(): prints out "Hi, I'm name, a age year old gender."
//GetGoal(): prints out "My goal is: Live for the moment!"
//And the following constructors:

//Person(name, age, gender)
//Person(): sets name to Jane Doe, age to 30, gender to female
//Student

//Create a Student class that has the same fields and methods as the Person class, and has the following additional

//fields:
//previousOrganization: the name of the student’s previous company / school
//skippedDays: the number of days skipped from the course
//methods:
//GetGoal(): prints out "Be a junior software developer."
//Introduce(): "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
//SkipDays(numberOfDays): increases skippedDays by numberOfDays
//The Student class has the following constructors:

//Student(name, age, gender, previousOrganization): beside the given parameters, it sets skippedDays to 0
//Student(): sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0
//Mentor

//Create a Mentor class that has the same fields and methods as the Personclass, and has the following additional

//fields:
//level: the level of the mentor(junior / intermediate / senior)
//methods:
//GetGoal(): prints out "Educate brilliant junior software developers."
//Introduce(): "Hi, I'm name, a age year old gender level mentor."
//The Mentor class has the following constructors:

//Mentor(name, age, gender, level)
//Mentor(): sets name to Jane Doe, age to 30, gender to female, level to intermediate
//Sponsor

//Create a Sponsor class that has the same fields and methods as the Personclass, and has the following additional

//fields:
//company: name of the company
//hiredStudents: number of students hired
//method:
//Introduce(): "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
//Hire(): increase hiredStudents by 1
//GetGoal(): prints out "Hire brilliant junior software developers."
//The Sponsor class has the following constructors:

//Sponsor(name, age, gender, company): beside the given parameters, it sets hiredStudents to 0
//Sponsor(): sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0
//PallidaClass

//Create a PallidaClass class that has the following

//fields:
//className: the name of the class
//students : a list of Students
//mentors: a list of Mentors
//methods:
//AddStudent(Student): adds the given Student to students list
//AddMentor(Mentor): adds the given Mentor to mentors list
//Info(): prints out "Pallida className class has students.size students and mentors.size mentors."
//The PallidaClass class has the following constructors:

//PallidaClass(className): beside the given parameter, it sets students and mentors as empty lists
//Result

//Your program should result this output if you run it with this input