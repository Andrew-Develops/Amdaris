using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Classroom
    {

        private static Classroom instance = new Classroom();


        private Classroom() { }

        // Lazy initialization
        public static Classroom GetClassroomInstanceLazy()
        {
            if (instance == null)
            {
                instance = new Classroom();
            }
            return instance;
        }

        // Early initialization
        public static Classroom GetClassroomInstanceEarly()
        {
            return instance;
        }

        public void PrintClassroom()
        {
            Console.WriteLine("This is a classroom");
        }

        public void GetMessage()
        {
            Console.WriteLine("This is a singleton class");
        }
    }
}
