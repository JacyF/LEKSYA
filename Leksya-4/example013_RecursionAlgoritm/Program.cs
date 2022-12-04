
// string[,] table = new string[2, 5];
// table[0, 0]  table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0]  table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// table[1, 2] = " word ";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columms = 0; columms < 5; columms++)
//     {
//         Console.WriteLine($" ={table[rows, columms]}=");  
//     }
// }

int[,] matrix = new int[3, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($" {matrix[i, j]}"); 
    }
    Console.WriteLine();
}