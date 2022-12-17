Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() =="дина")
{
Console.WriteLine("Ура это же ДИНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}