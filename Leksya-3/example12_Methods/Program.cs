// TYPE 1

void Method1()
{
    Console.Write(" Hi , Mister Bruno ") ;
}
// Method1();


// TYPE 2

void Method2(string msg)
{
    Console.Write(msg) ;
}
// Method2(msg : " Text ");

void Method21(string msg, int count)
{
    int i = 0 ;
    while (i < count )
    {
        Console.Write(msg) ;
        i++;
    }
}
// Method21(" Text " , 5);

// TYPE 3

int Method3()
{
    return DateTime.Now.Year ;
}
// int year = Method3();
// Console.Write(year);

// TYPE 3

string Method4(int count , string text)
{
    int i = 0 ;
    string result = string.Empty ;
    while(i < count )
    {
        result = result + text ;
        i++;
    }
    return result;
}
string res = Method4(10, " Bruno ");
Console.Write(res);
