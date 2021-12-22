
Console.Write("Введите расстояние:  ");
int distance = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите скорость первого друга ");
int firstFriendSpeed = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите скорость второго друга ");
int secondFriendSpeed = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите скорость собаки ");
int dogSpeed = int.Parse(Console.ReadLine()??"0");
int friend = 2;
int count = 0;
int time = 0;
while (distance > 10)
{
    if(friend == 1)
    {
        time = distance / (dogSpeed+firstFriendSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (dogSpeed+secondFriendSpeed);
        friend = 1;
    }
    distance = distance - time*(firstFriendSpeed+secondFriendSpeed);
    count = count + 1;
    
}
Console.WriteLine(count);