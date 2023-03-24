// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 1 ++++++++++++++++++++++++++++++++++
// Console.Write("Ввесдите число А:  ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Ввесдите число B:  ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {A} в степени {B} равно {Count_pow(A, B)}");

// int Count_pow (int numberA, int numberB){
//     int i = 1;
//     int res = numberA;
//     while (i<numberB){
//         res = res*numberA;
//         i++;
//     }
//     return res;
// }

// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 2 ++++++++++++++++++++++++++++++++++
// Console.Write("Ввесдите число А:  ");
// String A =Console.ReadLine();
// int sum = Sum_dig(A);
// Console.WriteLine($"Сумма цифр в числе равна: {sum}");

// int Sum_dig(string A) {
//     int sum = 0;
//     for (int i = 0; i < A.Length; i++) {
//         if (char.IsDigit(A[i])) {
//             sum += int.Parse(A[i].ToString());
//         }
//     }
//     return sum;
// }
// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 1 ++++++++++++++++++++++++++++++++++
// Console.Write("Ввесдите количество элементов массива:  ");
// int A =int.Parse(Console.ReadLine()!);

// (int[] array, int amount) = GetRandomArray(A,100,999);    // Из функции получаю две переменных 
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.Write("Количество четных:  ");
// Console.WriteLine(amount);


// // Из функции получаю две переменных (массив целочисленный и количество четных) в Функцию передаю 3 переменных для формирования массива
// (int[] result, int amount) GetRandomArray (int size, int minValue, int maxValue){  
//     int[] result = new int[size];
//     int amount = 0;
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(minValue, maxValue + 1);
//         if (result[i]%2 ==0) {
//             amount = amount+1;
//         } 
//     }
//     return (result, amount);
// }
// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 2 ++++++++++++++++++++++++++++++++++
// Console.Write("Ввесдите количество элементов массива:  ");
// int A =int.Parse(Console.ReadLine()!);

// (int[] array, int summa) = GetRandomArray(A,1,5);    // Из функции получаю две переменных 
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.Write("сумма элементов нечетных индексов  ");
// Console.WriteLine(summa);


// // Из функции получаю две переменных (массив целочисленный и сумму элементов на нечетных ячейках) в Функцию передаю 3 переменных для формирования массива
// (int[] result, int amount) GetRandomArray (int size, int minValue, int maxValue){  
//     int[] result = new int[size];
//     int summa = 0;
//     for (int i = 0; i < size; i++){
//         result[i] = new Random().Next(minValue, maxValue + 1);
//         if (i%2 ==0) {
//             summa = summa+result[i];
//         } 
//     }
//     return (result, summa);
// }
// ++++++++++++++++++++++++++++++++++++  ЗАДАЧА 3 ++++++++++++++++++++++++++++++++++
Console.Write("Ввесдите количество элементов массива:  ");
int A = int.Parse(Console.ReadLine()!);

double[] array = GetRandomArray(A, 1, 10);

double result = diff(array, A);
string result2 = result.ToString("0.00");

string[] formattedArray = new string[array.Length];
for (int i = 0; i < array.Length; i++) {
    formattedArray[i] = array[i].ToString("0.00"); // ограничиваем до двух символов после запятой
}

Console.WriteLine($"[{string.Join(", ", formattedArray)}]");
Console.WriteLine("Разница между мин и макс: ");
Console.WriteLine(result2);

double diff(double[] array, int size) {
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < size; i++) {
        if (array[i] < min) {
            min = array[i];
        }
        if (array[i] > max) {
            max = array[i];
        }
    }
    return max - min;
}

double[] GetRandomArray(int size, int minValue, int maxValue) {
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        result[i] = minValue + (maxValue - minValue) * rnd.NextDouble();
    }
    return result;
}
