// Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.

int[] GetArray() {
    int[] Massive = new int[5];
    for(int i = 0; i < Massive.Length; i++) {
        Massive[i] = new Random().Next(1, 101);
    }
    return Massive;
  
}
void CheckValue(int[] Massive) {
    Console.WriteLine("Задайте число: ");
    int num = int.Parse(Console.ReadLine());
    String Answer = "нет";
    for (int i = 0; i < Massive.Length; i++) {
       if (Massive[i] == num) {
        Answer = "да";
        break;
       }
    }
    System.Console.WriteLine(Answer);
}

void Main() {
    int[] Massive = GetArray();
    System.Console.WriteLine("[" + String.Join(", ", Massive) + "]");
    CheckValue(Massive);
}

Main();


