Console.Write("Distance between friends: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("The dog runs towards a friend: ");
int friend = Convert.ToInt32(Console.ReadLine());
Console.Write("speed friend №1: ");
int friendsspeed1 = Convert.ToInt32(Console.ReadLine());
Console.Write("speed friend №2: ");
int friendsspeed2 = Convert.ToInt32(Console.ReadLine());
Console.Write("speed dog: ");
int dogspeed = Convert.ToInt32(Console.ReadLine());

int count = 0;
int time = 0;

while(distance > 5)
{
    if (friend == 1) 
    {
        time = distance / (friendsspeed1 + dogspeed);
        friend = 2;
    } 
    else 
    {
        time = distance / (friendsspeed2 + dogspeed);
        friend = 1;
    }
    distance = distance - ((friendsspeed1 + friendsspeed2) * time);
    count++;
}
Console.WriteLine(count);