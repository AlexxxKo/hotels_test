// Написать метод/функцию, который/которая на вход принимает число (int), а на выходе выдает слово “компьютер” в падеже, соответствующем указанному количеству. Например, «25 компьютеров», «41 компьютер», «1048 компьютеров».

string Computers(int num) {
    if (num % 10 == 1 && !(num > 10 && num < 20)) return $"{num} компьютер";
    else if ((num % 10 >= 2 && num % 10 <= 4) && !(num > 10 && num < 20)) return $"{num} компьютера";
    else return $"{num} компьютеров";
}

int number = 148;
string comp = Computers(number);
Console.WriteLine(comp);

// Time: ~30 мин.