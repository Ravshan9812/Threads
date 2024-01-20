//using System;
//using System.Threading;
//using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        PrepareBreakfastAsync();
    }

    static void PrepareBreakfastAsync()
    {
        Console.WriteLine("Starting breakfast...");

        Task makeTeaTask = new Task(MakeTeaAsync);
        makeTeaTask.Start();

        Task makeCakeTask = new Task(MakeCakeAsync);
        makeCakeTask.Start();

        Task fryEggsTask = new Task(MakeFriedeEggsAsync);
        fryEggsTask.Start();

        Task frySausagesTask = new Task(MakeFriedSausagesAsync);
        frySausagesTask.Start();

        Task otherThingsTask = new Task(OtherThingsAsync);
        otherThingsTask.Start();

        makeTeaTask.Wait();
        makeCakeTask.Wait();
        fryEggsTask.Wait();
        frySausagesTask.Wait();
        otherThingsTask.Wait();

        Console.WriteLine("Bring to the table and Bon appetite!");
    }

    static void MakeTeaAsync()
    {
        Console.WriteLine("Starting boiling water...");
        Thread.Sleep(2000);
        Console.WriteLine("Water boiled. Tea ready!");
    }

    static void MakeCakeAsync()
    {
        Console.WriteLine("Put the cake in cooker...");
        Console.WriteLine("Start cooking...");
        Thread.Sleep(3000);
        Console.WriteLine("Cake is ready!");
    }

    static void MakeFriedeEggsAsync()
    {
        Console.WriteLine("Craking eggs...");
        Console.WriteLine("Frying eggs...");
        Thread.Sleep(4000);
        Console.WriteLine("Eggs ready!");
    }

    static void MakeFriedSausagesAsync()
    {
        Console.WriteLine("Cutting sausage...");
        Console.WriteLine("Frying sausage...");
        Thread.Sleep(5000);
        Console.WriteLine("Sausages ready!");
    }

    static void OtherThingsAsync()
    {
        Console.WriteLine("Put the table other things...");
        Console.WriteLine("Sugar, jam, biscuits, butter and etc...");
        Thread.Sleep(6000);
        Console.WriteLine("Everything is ready!");
    }
}