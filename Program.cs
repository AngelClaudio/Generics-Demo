namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Generics allows us to specify a type in the angle brackets
        // Using types makes it a more efficient process, you get compile time checks,
        // and you don't have the expensive operation of boxing and unboxing values.
        List<int> numbers = [1, 2, 3];
        List<string> strings = ["Tim", "Corey", "Sue"];


        List<object> objects = ["Tim", 4, 3.6];
        /* 
           Not recommended, because it's not "Type Safe"

           Also behind the scenes "boxing" happens, e.g. 4 is a value type, and objects
           is a reference type, so in order to put 4 into "objects", you have to convert it.
           Therefore, 4 changes where it is located in memory and it is an expensive operation to
           box and unbox 4.
        */

        TypeChecker(1);
        TypeChecker("Angel");

        TypeChecker(new PersonRecord("Tim", "Corey"));

        BetterList<int> betterNumbers = new();
        betterNumbers.AddToList(5);

        BetterList<PersonRecord> people = new();
        people.AddToList(new("Tim", "Corey"));
        
    }
    static void TypeChecker<T>(T value) // T is the identifier for Generics (you don't have to use T, but that is the common convention)
    {
        Console.WriteLine("Type: " + typeof(T));
        Console.WriteLine("Value: " + value);
    }

    record PersonRecord(string FirstName, string LastName); // record is new since C# 9; immutable, data storage only, value-based equality when using struct unless class is used, auto properties.
}

