int [] array = {22,44,56,85,90,44,43,64,23,45,};

int n = array.Length;

int find = 44 ;

int index = 0 ;

while (index < n )
{
    if (array[index] == find )
    {
        Console.WriteLine(index);
        break;
    }
    index++;
} 
