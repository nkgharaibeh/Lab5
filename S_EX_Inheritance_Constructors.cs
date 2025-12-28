 using System;
/*
     * SLIDE: "C# || Inheritance Constructors Example"
     * GOAL:
     * - Show constructor execution order in inheritance.
     * - Base constructor runs first, then child constructor.
     *
     * WHY?
     * - A derived object contains a base part + derived part.
     * - The base part must be constructed before the derived part can use it.
     *
     * OUTPUT (like slide):
     * - I am Default baseclass Constructor
     * - I am Default childclass Constructor
     * - baseclass Constructor Message : Hello Constructor
     * - childclass Constructor Message : Hello Constructor
     */
namespace Inheritance_Constructors
{
    

    class baseclass
    {
        public baseclass()
        {
            Console.WriteLine("I am Default baseclass Constructor");
        }

        public baseclass(string message)
        {
            Console.WriteLine("baseclass Constructor Message : " + message);
        }
    }

    class childclass : baseclass
    {
        public childclass()
        {
            Console.WriteLine("I am Default childclass Constructor");
        }
        // IMPORTANT:
        // ': base(message)' means call the parent constructor first
        // before executing the child constructor body.
        public childclass(string message) : base(message)
        {
            // ': base(message)' explicitly calls the base constructor with the same parameter.
            Console.WriteLine("childclass Constructor Message : " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            childclass ch = new childclass();  // This triggers:  1) BaseClass() then ChildClass()
            childclass ch1 = new childclass("Hello Constructor"); // This triggers:  1) BaseClass(string) then ChildClass(string)

            Console.ReadKey();
        }
    }
}
/*
SLIDE CONNECTION:
- Constructor chaining in inheritance:
  Base part of the object is constructed first, then the derived part.
*/
