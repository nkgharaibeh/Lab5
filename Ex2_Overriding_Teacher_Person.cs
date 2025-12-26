using System;

namespace Example_2___Overriding
{

    using System;

    class Person
    {
        
        public virtual void Greet()     // 'virtual' means: "I allow derived classes to change this behavior".
        {
            Console.WriteLine("Hello, I am a person.");
        }
    }

    class Teacher : Person
    {
        public override void Greet()     // 'override' means: "I replace the base implementation with my own".
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

            p.Greet(); // base behavior
            t.Greet(); // overridden behavior

      /*
        SLIDE CONNECTION:
        - Inheritance is not only about reuse; it also enables customization (override).
        - This is a bridge to Polymorphism: same method name, different behavior.
     */
        }
    }

}
