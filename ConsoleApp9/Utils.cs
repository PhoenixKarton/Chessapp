public static class Utils
{
    public static void TryClear()
    {
        try 
        {
            Console.Clear();
        }
        catch
        {
            Console.WriteLine("\nCLEAR()\n");
        }
    }

    public static void SetCursorPosition(int left, int top)
    {
        try 
        {
            Console.SetCursorPosition(left, top);
        }
        catch
        {
            Console.WriteLine($"\nSeCursorPosition({left},{top})\n");
        }
    }

    public static string ReadLine()
    {
        string input = Console.ReadLine()!;
        StreamWriter outputFile = File.AppendText("temp_inputs.txt");
        outputFile.WriteLine(input);
        outputFile.Close();
        return input;
    }
}