// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке[10,99].

int[] GetArray() {
    int[] Massive = new int[123];
    for (int i = 0; i < Massive.Length; i++) {
        Massive[i] = new Random().Next(-2, 101 );
    } 
    return Massive;
}

int GetNumber(int[] Massive) {
    int Count = 0;
    for (int i = 0; i < Massive.Length; i++)
    {
        if (Massive[i] >= 10 && Massive[i] <= 99) {
            Count++;
        }   
    }

    return Count;
}

void Main () {
    int[] Arr = GetArray();
    System.Console.WriteLine("[" + String.Join(", " , Arr) + "]");
    int Num = GetNumber(Arr);
    System.Console.WriteLine(Num);
}
Main();


