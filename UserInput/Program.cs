using System;

public class TextInput 
{
    protected string value;
    public virtual void Add(char c)
    {
        value += c;
    }

    public string GetValue()
    {
        return value;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if (char.IsDigit(c))
        {
            value += c;
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}