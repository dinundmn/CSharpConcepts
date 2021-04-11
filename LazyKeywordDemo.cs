using System;
using System.Collections.Generic;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<MockStudentData> lazyStudData = new Lazy<MockStudentData>();

            string input;
            while (true)
            {
                Console.WriteLine("Do you want to load stud details");
                input = Console.ReadLine();

                if (input == "yes")
                {
                    List<Student> Students = lazyStudData.Value.Students;
                }
            }
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class MockStudentData
    {
        private readonly List<Student> m_students = null;

        public List<Student> Students { get { return m_students; } }

        public MockStudentData()
        {
            m_students = new List<Student>();
            PopulateStudentData();
        }

        private void PopulateStudentData()
        {
            for (int i = 1; i < 10; i++)
            {
                m_students.Add(new Student { ID = i, Name = $"TestName_{i}"});
                Console.WriteLine($"Populated data for student {i}");
            }
        }
    }
}
