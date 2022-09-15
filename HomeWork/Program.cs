double distance = 10000;
int count = 0;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double temp = 0;


while (distance > 10)
{
    if (friend == 1)
    {
        temp = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else 
    {
        temp = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
distance = distance - (firstFriendSpeed + secondFriendSpeed) * temp;
count = count + 1;
}
Console.WriteLine(count);

