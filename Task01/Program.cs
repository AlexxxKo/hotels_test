// Написать метод/функцию, который/которая на вход принимает массив городов. В качестве результата возвращает строку, где города разделены запятыми, а в конце стоит точка. Например, «Москва, Санкт-Петербург, Воронеж.»

string GetPropositionCity(string[] arr) {
    string propCity = String.Empty;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1) {
            propCity += $"{arr[i]}.";
        }
        else {
            propCity += $"{arr[i]}, ";
        }
    }
    return propCity;
}

string[] arrayCity = {"City1", "City2", "City3", "City8"};
string Cities = GetPropositionCity(arrayCity);

Console.WriteLine(Cities);

// Time: ~30 мин.