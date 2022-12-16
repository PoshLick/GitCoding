Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "аня")
{
    Console.WriteLine("Кто это у нас тут? Это же Анюта!");
}
else
{
    Console.Write("Ты не Аня, пошёл нах#й, ");
    Console.WriteLine(username);
}