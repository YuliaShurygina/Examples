
//Console.WriteLine("Введите расстояние ");
int distance = 10000;
//Console.WriteLine("Введите скорость первого друга ");
int firstFriendSpeed = 1;
//Console.WriteLine("Введите скорость второго друга ");
int secondFriendSpeed = 2;
//Console.WriteLine("Введите скорость собаки ");
int dogSpeed = 5;
int friend = 2;
int count = 0;
while (distance>10)
{
    if(friend == 1)
    {
        double time = distance / (dogSpeed+firstFriendSpeed);
        friend = 2;
    }
    else
    {
        double time = distance / (dogSpeed+secondFriendSpeed);
        friend = 1;
    }
    distance = distance - time*(firstFriendSpeed+secondFriendSpeed);
    count = count + 1;
    
}
Console.WriteLine(count);