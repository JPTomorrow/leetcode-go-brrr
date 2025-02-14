public class AsyncAwaitExample
{
    // calling this method will run all the tasks concurrently
    // and then await to retrieve the results in the order that is needed 
    // regardless of whether all the tasks are finished or not
    public async Task MakeChickenSandwich()
    {
        // start all the tasks concurrently
        var breadChickenTask = BreadChickenAsync();
        var fryChickenTask = FryChickenAsync();
        var makeSandwichTask = MakeSandwichAsync();
        Console.WriteLine("Starting to make chicken sandwich!!!");

        // do stuff while the tasks run.
        Console.WriteLine("Completely unrelated stuff!!!");

        // await to get the results of the task in the correct order
        await breadChickenTask;
        await fryChickenTask;
        await makeSandwichTask;

        Console.WriteLine("We made a chicken sandwich!!!");
    }

    private async Task BreadChickenAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Finished Breading Chicken");
    }

    private async Task FryChickenAsync()
    {
        await Task.Delay(3000);
        Console.WriteLine("Finished Frying Chicken");
    }

    private async Task MakeSandwichAsync()
    {
        await Task.Delay(4000);
        Console.WriteLine("Finished Making Sandwich");
    }
}