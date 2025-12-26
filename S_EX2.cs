using System;

namespace Member_Variable
{
    /*
     * SLIDE: "C# || Programming Example 2" (Access Private Member in Child Class)
     * GOAL:
     * - Demonstrate: private fields are inherited (they exist inside the object),
     *   but they are NOT directly accessible from the derived class.
     * - Solution: expose private field safely using a public Property (GET/SET).
     *
     * WHY THIS MATTERS (Encapsulation):
     * - We hide implementation details (private field) to protect invariants and prevent invalid states.
     * - We expose a controlled interface (Property) to allow safe read/write.
     */

    class baseclass
    {
        public int pub_var = 5;
        protected int pro_var = 6;
        internal int inter_var = 7;

        // Private field: hidden implementation detail
        private int pri_var = 8;

        // Property: controlled exposure of private field
        public int Private_variable
        {
            get
            {
                // GET returns the hidden private field value
                return pri_var;
            }
            set
            {
                // SET updates the hidden private field value
                // (In real systems you can add validation here.)
                pri_var = value;
            }
        }
    }

    class childclass : baseclass
    {
        public void check()
        {
            // ✅ Access allowed:
            int sum = pub_var + pro_var + inter_var + Private_variable;

            Console.WriteLine("Total : " + sum.ToString());

            // ❌ Not allowed (uncomment to see compile error):
            // int x = pri_var; // private field not accessible in derived class
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            childclass ch = new childclass();
            ch.check();

            Console.ReadKey();
        }
    }
}
