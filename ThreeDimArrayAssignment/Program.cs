namespace ThreeDimArrayAssignment
{
    internal class Program  //A program designed to calculate the multiplication of a 3 by 3 dimensional arrays.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Multiplication of the 3Dimensional array is: ");

            //Declaration andIntialization of the first array.
            int[,,] threeDimArray = new int[2, 2, 2]  
            {
               { {2,3}, {3,4}, }, 
               { {4,5}, {5,6},}
            };

            // Declaration and Intialization of the second array.
            int[,,] threeDimArray2 = new int[2, 2, 2] 
           {
               { {8,3}, {7,1}, },
               { {5,4}, {6,2},}
           };

            //Declaration of the result array.
            int[,,] result = new int[2, 2, 2];

            for (int i = 0; i < threeDimArray.GetLength(0); i++)

            {
                

                for (int j = 0; j < threeDimArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDimArray.GetLength(2); k++)
                    {
                        result[i, j, k] += threeDimArray2[i, j, k] * threeDimArray[i, j, k]; //Computing the result of the 3 by 3 arrays.
                        Console.WriteLine(result[i,j,k]);
                    }

                }
                
                Console.WriteLine();
            }

        }

        

    }
}