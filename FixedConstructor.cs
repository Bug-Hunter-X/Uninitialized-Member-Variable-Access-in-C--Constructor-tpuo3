public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value; // Assign the value to MyProperty in the constructor 
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); 
    }
}