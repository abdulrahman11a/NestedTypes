class Program
{
    static void Main()
    {
        // Creating an outer object
        OuterClass outer = new OuterClass();

        // Accessing nested class
        OuterClass.InnerClass inner = new OuterClass.InnerClass();
        inner.PrintMessage();
    }
}

#region Outer Class
public class OuterClass
{
    public void SayHello()
    {
        Console.WriteLine("Hello from OuterClass!");
    }

    #region Nested Class Explanation
    /*
     *  #Nested Class:
     * - A class defined within another class.
     * - It's called a **nested class** (or inner class).
     * 
     *  #Why use nested classes?
     * - To group related functionality that only makes sense inside the outer class.
     * - To hide the inner logic from outside code (e.g., utility or helper logic).
     * - For better **encapsulation** and **code organization**.
     * 
     *  #When to use:
     * - If the inner class is only relevant to the outer class.
     * - If you want to keep utility logic private or logically grouped.
     * 
     *  #When NOT to use:
     * - If the inner class needs to be reused in other classes.
     * - If it makes the code harder to read or violates single-responsibility.
     * 
     *  #Real Use Case:
     * - A `Parser` class with a private nested `Token` class.
     * - A `Car` class with a nested `Engine` class to hide engine implementation.
     */
    #endregion
    #region Inner Class
    public class InnerClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello from InnerClass!");
        }
    }
    #endregion
}
#endregion
