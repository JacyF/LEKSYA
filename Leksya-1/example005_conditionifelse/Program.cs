Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if ( username.ToLower() == "bruno" )
{
    Console.WriteLine(" Ура, это BRUNO");
}
else
{
    Console.WriteLine(" Привет , ");
    Console.WriteLine(username);
}
