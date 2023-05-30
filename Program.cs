
try
{
    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine(myNumbers[10]); // error!
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}