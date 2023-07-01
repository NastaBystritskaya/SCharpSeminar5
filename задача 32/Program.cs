// Напишите программу замена элементов массива: положительные замените на соответствующие отрицательные и наоборот. 

int[] GetArray() {
    int[] Massive = new int[4];
    for (int i = 0; i < Massive.Length; i++) {
        Massive[i] = new Random().Next(-99, 100);
    }
    return Massive;
} 

int[] Swap(int[] Array) {
    for (int i = 0; i < Array.Length; i++) {
        Array[i] =  Array[i] * (-1);
    }
    return Array;
}

void Main() {
    int[] Array =  GetArray();
    System.Console.WriteLine(String.Join(", ", Array));

    int[] Swaped = Swap(Array);
    System.Console.WriteLine(String.Join(", " , Swaped));
}

Main();