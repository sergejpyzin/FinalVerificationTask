namespace FinalVerificationTask
{
    internal class Program
    {
        static int GetNumberUserMassedge(string userMassedge)
        {
            int userNumber = 0;
            while (true)
            {
                Console.Write(userMassedge);
                bool check = int.TryParse(Console.ReadLine(), out userNumber);
                if (check) return userNumber;
                else Console.WriteLine("Ошибка! Попробуйте еще раз.");
            }
        }
        void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write($"{array.Length - 1}");
            Console.WriteLine($"]");
        }
        static string[] CreateArray (int length)
        {
            string[] stringArray = new string[length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write ("Введите элемент массива: ");
                stringArray[i] = Console.ReadLine();
            }
            return stringArray;
        }
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