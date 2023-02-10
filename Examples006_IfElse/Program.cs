Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "алексей")
{
    Console.WriteLine("Ура, это же Алексей!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}