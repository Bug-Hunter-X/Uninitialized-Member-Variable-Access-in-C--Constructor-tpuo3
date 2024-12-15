public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing MyProperty before it's assigned in the constructor
        Console.WriteLine(MyProperty); //Bug: The value of MyProperty might not be initialized. 
    }
}