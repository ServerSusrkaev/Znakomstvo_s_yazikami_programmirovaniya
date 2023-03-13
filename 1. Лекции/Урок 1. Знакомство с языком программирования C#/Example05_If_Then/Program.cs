Console.WriteLine("Введите ваше имя: ");
string Name = Console.ReadLine();

if (Name.ToLower() == "маша")
{
    Console.WriteLine("Эдравствуй мой дорогой друг Маша");
}
else
{
    Console.WriteLine("Эдравствуйте " +Name);
}