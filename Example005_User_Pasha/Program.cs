
Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "паша")
{

    Console.WriteLine("Ура, это же Паша!");
}
    else
{

    Console.Write("Привет, ");
    Console.WriteLine(username);
}
