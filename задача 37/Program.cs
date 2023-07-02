// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 

int[] GetArray() {
    int[] Massive = new int[6];
    for (int i = 0; i < Massive.Length; i++) {
        Massive[i] = new Random().Next(1, 11);
    }
    return Massive;
}

int[] PrintResult(int[] Massive) {
    int[] NewArray = new int[Massive.Length / 2];
    for (int i = 0; i < Massive.Length; i++)
    {
        if (i >= Massive.Length - 1 - i) {
            break;
        }
        else {
            int Result = Massive[i] * Massive[Massive.Length - 1 - i];
            NewArray[i] = Result;
        }
    }
    return NewArray;
}

void Main() {
    int[] Array = GetArray();
    System.Console.WriteLine("[" + String.Join(", ", Array) + "]");
    int[] Result = PrintResult(Array);
    System.Console.WriteLine("[" + String.Join(", ", Result) + "]");
}

Main();