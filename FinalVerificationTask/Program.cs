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
        static void PrintArray(string[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write($"{array[array.Length - 1]}");
            Console.WriteLine($"]");
        }
        static string[] GetStringArray (int length)
        {
            string[] stringArray = new string[length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write ("Введите элемент массива: ");
                stringArray[i] = Console.ReadLine();
            }
            return stringArray;
        }
        static string[] GetNewArray (string[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                string[] newArray = new string[count];
                count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        newArray[count] = array[i];
                        count++;
                    }
                }
                return newArray;
            }
            else 
            {
                string[] newArray = {" "};
                return newArray;
            }
        }
        static void Main(string[] args)
        {
            int arrayLength = GetNumberUserMassedge("Введите значение длинны массива: ");
            string[] myArray = GetStringArray(arrayLength);
            string[] newArray = GetNewArray(myArray);
            PrintArray(newArray);
        }
    }
}