// See https://aka.ms/new-console-template for more information
int trueWordsCount = 0; // Счетчик правильных строк

// Получение входного массива
Console.WriteLine("Введите данные через пробел и нажмите Enter ");
string? input = Console.ReadLine();
if (input == null)
    input = "";
char[] separators = new char[] { ' ' };
string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

// Получение размера массива - результата
for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3)
        trueWordsCount++;
string[] result = new string[trueWordsCount];
int resultCount = 0;

// Заполнение массива - результата
for (int i = 0; i < inputArray.Length; i++)
    if (inputArray[i].Length <= 3)
        {
            result[resultCount] = inputArray[i];
            resultCount++;
        }

// Вывод результата
string printResult = "";
if (input != "")
    printResult += "[";
for (int i = 0; i < inputArray.Length; i++)
{
    if (i == inputArray.Length - 1)
        printResult += $"\"{inputArray[i]}\"] -> [";
    else
        printResult += $"\"{inputArray[i]}\", ";
}
for (int i = 0; i < result.Length; i++)
{
    if (i == result.Length - 1)
        printResult += $"\"{result[i]}\"]";
    else
        printResult += $"\"{result[i]}\", ";
}
    
Console.WriteLine(printResult);
