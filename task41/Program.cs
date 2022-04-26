// Пользователь вводит с клавиатуры или задает самостоятельно M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел будет введено?");
int[] nums = new int[Convert.ToInt32(Console.ReadLine())];
int count = 0;
for (int i = 0; i < nums.Length; i++) {
    Console.WriteLine($"Введите число №{i + 1}");
    nums[i] = Convert.ToInt32(Console.ReadLine());
    if (nums[i] > 0) count++;
}
Console.WriteLine($"Введено {count} чисел больше 0");