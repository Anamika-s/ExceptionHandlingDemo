using System;
 
  class CustomException : Exception
{
    public string msg;
    public CustomException(string msg)
    {
        this.msg = msg;
    }
}

 
    class Program
    {
    static void Main(string[] args)
    {
        int marks;
        string name;
        try
        {
            Console.WriteLine("Enter Marks");
            marks = Convert.ToByte(Console.ReadLine());
            if (marks < 0 || marks > 100)
                throw new CustomException("Marks should be in Range 0 - 100");
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            if (name.Length < 10)
                throw new CustomException("Minimum 10 characters are needed");

            Console.WriteLine("Name is " + name);
            Console.WriteLine("Marks are " + marks);
        }
        catch (CustomException obj)
        {
            Console.WriteLine(obj.msg);
        }
        catch (FormatException obj)
        {
            //  Console.WriteLine(obj.Message);

            Console.WriteLine("Please enter number");
        }
        catch (OverflowException obj)
        {
            Console.WriteLine(obj.Message);
            Console.WriteLine("Please enter numbers within Range 0 -255");
        }

        catch (Exception obj)
        {
            Console.WriteLine(obj);
        }
        finally
        {
            // Clean up Activities
            // Close file handlers, database connections

            Console.WriteLine("FINALLY BLOCK");
        }


    }
    }

