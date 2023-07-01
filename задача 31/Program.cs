// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива. 

int[] array = new int[12];
int sum_positive = 0;
int sum_negative = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(-9, 10);
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
for (int i = 0; i < array.Length; i++){
    if (array[i]>0) {
        sum_positive += array[i];
    }
    else {
        sum_negative += array[i];
    }
}
System.Console.WriteLine($"Сумма положительных элементов массива: {sum_positive}");
System.Console.WriteLine($"Сумма отрицательных элементов массива: {sum_negative}");