// TYPE 1

void Method1()
{
    Console.Write(" Hi , Mister Bruno ");
}
// Method1();


// TYPE 2

void Method2(string msg)
{
    Console.Write(msg);
}
// Method2(msg : " Text ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}
// Method21(" Text " , 5);

// TYPE 3

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.Write(year);

// TYPE 4

// string Method4(int count , string text)
// {
//     int i = 0 ;
//     string result = string.Empty ;
//     while(i < count )
//     {
//         result = result + text ;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{

    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, " Bruno ");
// Console.Write(res);


// for (int i = 2; i <= 12 ; i++ )
// {
//     for (int j = 1 ; j <= 12 ; j++ )
//     {
//         Console.WriteLine($" { i } x { j } = { i*j } ");
//     }
//     Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, // маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ " ежели бы вас послали вместо нашего милого Винценгероде,"
+ " вы бы взяли приступом согласие прусского короля."
+ " Вы так красноречивы. Вы дадите мне чаю? ";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $" {text[i]}";
    }
    return result;
}
// string newText = Replace(text , ' ','|' );
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText , 'к','К' );
// Console.WriteLine(newText);


int[] arr = { 1, 4, 5, 8, 3, 5, 9, 1, 0 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int [] array)
{
    for ( int i = 0 ; i < array.Length - 1; i++)
    {
        int minPosition = i ;

        for ( int j = i+1 ; j < array.Length ; j++)
        {
            if ( array[j] < array[minPosition]) minPosition = j ;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary ;
    }
}



void MaxSelectionSort(int [] array)
{
    for ( int i = 0 ; i < array.Length - 1; i++)
    {
        int maxPosition = i ;

        for ( int j = i+1 ; j < array.Length ; j++)
        {
            if ( array[j] > array[maxPosition]) maxPosition = j ;
        }


        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary ;
    }
}


Console.WriteLine(" Array : ");
PrintArray(arr);
Console.WriteLine();

Console.WriteLine(" From Min to Max ");
SelectionSort(arr) ;
PrintArray(arr);
Console.WriteLine();

Console.WriteLine(" From Max to Min ");
MaxSelectionSort(arr) ;
PrintArray(arr);


