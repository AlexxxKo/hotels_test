// Написать метод/функцию, который/которая на вход принимает число (float), а на выходе получает число, округленное до пятерок. 

int FiveNumber(double num) {
    bool isNegative = num < 0 ? true : false;

    int round = (int) Math.Abs(Math.Round(num, 0));
    int rest = round % 10;
    
    if (rest < 5) {
        round = round - rest;
        if (rest > 2) round =+ 5;
    } else {
        round = round - rest + 5;
        if (rest > 7) round += 5;
    }

    return isNegative ? -round : round;
}

double number = -2.73;
int lastNum = FiveNumber(number);
Console.WriteLine(lastNum);

// Time: ~30 мин.