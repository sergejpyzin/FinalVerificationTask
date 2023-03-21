namespace FinalVerificationTask
{
    internal class Program
    {
        static void GetNewArray (string[] array)
        {
            string[]newArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[i] = array[i];                    
                } 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}