using System;

namespace Example_2___Overriding
{

    using System;

    class Person
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello, I am a person.");
        }
    }

    class Teacher : Person
    {
        public override void Greet()
        {
            Console.WriteLine("Hello, I am a teacher.");
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            Teacher t = new Teacher();

            p.Greet();
            t.Greet();
        }
    }

}
