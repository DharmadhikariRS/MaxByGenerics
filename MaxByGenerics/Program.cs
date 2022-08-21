namespace MaxByGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1
            //Console.WriteLine("Find Maximum of 3 float numbers");
            //int input;
            //int[] intArray = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} number", i + 1);
            //    input = int.Parse(Console.ReadLine());
            //    intArray[i] = input;
            //}
            //IntMax.toPrint(intArray);

            //UC2
            //Console.WriteLine("Find Maximum of 3 float numbers");
            //float input;
            //float[] floatArray = new float[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} number", i + 1);
            //    input = float.Parse(Console.ReadLine());
            //    floatArray[i] = input;
            //}
            //FloatMax.toPrint(floatArray);

            // UC3

            //Console.WriteLine("Find Maximum of String");
            //string input;
            //string[] stringArray = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} string", i + 1);
            //    input = Console.ReadLine();
            //    stringArray[i] = input;
            //}
            //StringMax.toPrint(stringArray);

            //Uc4
            //Console.WriteLine("Max of integers  3,2,1 is ");
            //Console.WriteLine();
            //MaxUsingParams.toPrint(3, 2, 1);
            //Console.WriteLine();
            //Console.WriteLine("Max of Float 3.1, 2.3, 1.5, 5.4");
            //Console.WriteLine();
            //MaxUsingParams.toPrint(3.1f, 2.3f, 1.5f, 5.4f);
            //Console.WriteLine();
            //Console.WriteLine("Max of strings  Singing, Read, Swimming is ");
            //Console.WriteLine();
            //MaxUsingParams.toPrint("Singing", "Read", "Swimming");

            ////Uc5
            Console.WriteLine("Max of integers  3,2,1 is ");
            Console.WriteLine();
            MaxByGenerics.FidMax(3, 2, 1);
            Console.WriteLine();
            Console.WriteLine("Max of Float 3.1, 2.3, 1.5, 5.4 is ");
            Console.WriteLine();
            MaxByGenerics.FidMax(3.1, 2.3, 1.5, 5.4);
            Console.WriteLine();
            Console.WriteLine("Max of strings  Singing, Read, Swimming is ");
            Console.WriteLine();
            MaxByGenerics.FidMax("Singing", "Read", "Swimming");

        }
    }
}