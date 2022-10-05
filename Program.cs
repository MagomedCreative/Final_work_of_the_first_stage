string[] array = { "project-d", "toyota", "86", "gr86" };
string[] result = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) result[i] = array[i];
    else result[i] = string.Empty;
    if (result[i] != string.Empty) Console.Write($"{result[i]} ");
}