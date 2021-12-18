// Задача: Два друга идут на встречу друг другу с какой то скоростью V1 и V2. 
// У них есть собака и она бегает от первого друга ко второму и обратно пока друзья не встретятся. 
// Начинает свой бег собака от первого друга. 
// Сколько раз собака перебежит от одного друга до другого?

Console.Write("Введите скорость первого друга в м/с: "); 
int speedFirstFriend = Int32.Parse(Console.ReadLine());
Console.Write("Введите скорость второго друга в м/с: ");
int speedSecondFriend = Int32.Parse(Console.ReadLine());
Console.Write("Введите скорость собаки в м/с: ");
int speedDog = Int32.Parse(Console.ReadLine());

Console.Write("Введите расстояние между друзьями в м: ");   // По хорошему, надо добавить функцию на корректный ввод расстояний. 
int distanse = Int32.Parse(Console.ReadLine());                // Расстояния не должны быть =< 0 и расстояние между друзьями должно быть > расстояния встречи
Console.Write("Введите расстояние, меньше которого считаем, что друзья встретились в м: ");
int distanseMeeting = Int32.Parse(Console.ReadLine());

int count = 0; // Счетчик количества пробежек собаки
Boolean dogRunToSecondFriend = true; // false - собака бежит от первого ко второму, true - собака бежит от второго к первому
int time = 0;

while (distanse > distanseMeeting) 
{
    if (!dogRunToSecondFriend)
    {
        time = distanse / (speedFirstFriend + speedDog);
        dogRunToSecondFriend = true;
    }
    else
    {
        time = distanse / (speedSecondFriend + speedDog);
        dogRunToSecondFriend = false;
    }

    distanse = distanse - (speedFirstFriend + speedSecondFriend) * time;
    count++;
    
}

Console.WriteLine("Собака пробежала " + count + " раз");
