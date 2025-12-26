vusing System;
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

namespace Member_Variable
{
    
    class baseclass
    {
        public int pub_var = 5;  // Accessible everywhere
        protected int pro_var = 6; // Accessible in derived classes 
        internal int inter_var = 7;  // Accessible within same assembly/project

        // Private field: hidden implementation detail
        private int pri_var = 8;
    // IMPORTANT SLIDE NOTE:
    // Private member is inherited (it exists in the object),
    // but it is NOT accessible directly in the child class.
    // To expose it safely, we use a public property (GET/SET).
        
        //Therfore, Property: controlled exposure of private field
        
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
/*
SLIDE CONNECTION:
- Child class can access: public, protected, internal, protected internal.
- Private cannot be accessed directly, but can be exposed via public Property (GET/SET).
*/
