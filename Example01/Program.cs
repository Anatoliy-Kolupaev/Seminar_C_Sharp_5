
// Дополнительно: Написать программу которая из имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон

//string word = System.Console.ReadLine();
//string[] num = word.Split(" ");     //команда которая дает разделить строку убрать пробелы
//for (int i = 0; i < num.Length; i++)
//{
//    System.Console.WriteLine(num[i]);
//}
string words = Console.ReadLine();
Console.WriteLine(words);
string[] nums = words.Split(",");
int index = new Random().Next(0,nums.Length);
Console.WriteLine(nums[index]);
