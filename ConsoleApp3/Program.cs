#region Task1
/*
// Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək

Console.WriteLine("Please enter a sentence: ");
string sentence1, sentence2 = "";
sentence1 = Console.ReadLine();
int j = 0;
for (int i = 0; i < sentence1.Length; i++) {
    if (sentence1[i] != ' ')
        sentence2 += sentence1[i];
}
Console.WriteLine($"Newly created sentence:\n{sentence2}");
*/
#endregion

#region Task2
/*
// Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram

int size;
do {
    Console.WriteLine("Please enter the size of array: ");
    size = int.Parse(Console.ReadLine());
} while(size <= 0);

int[] numbers = new int[size];

Console.WriteLine("Please enter the number `n` to search for");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < size; i++) {
    Console.Write("Please enter a number for array: ");
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}
bool nFound = false;
for (int i = 0; i < size; i++) {
    if (numbers[i] == n) {
        Console.WriteLine($"`{n}` is located on the index {i}");
        nFound = true;
        break;
    }
}

if (!nFound) Console.WriteLine($"{n} is not there!");
*/
#endregion

#region Task3
/*
// Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

int size;
int count = 0;
do {
    Console.WriteLine("Please enter the size of array: ");
    size = int.Parse(Console.ReadLine());
} while (size <= 0);

int[] numbers = new int[size];

Console.WriteLine("Please enter the number `n` to search for");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < size; i++) {
    Console.Write("Please enter a number for array: ");
    int number = int.Parse(Console.ReadLine());
    numbers[i] = number;
}

for (int i = 0; i < size; i++) {
    if (numbers[i] == n) count++;
}
Console.WriteLine($"There are {count} times `{n}` there.");
*/
#endregion

#region Task4
/*
// Verilmiş yazının her iki terefindeki boşluqlar silinmiş bir string düzəldən proqram

Console.WriteLine("Please enter a sentence: ");
string sentence1 = Console.ReadLine();
string sentence2 = "";

int index = 0;
bool reachedLetter = false;
while (true) {
    if (sentence1[index] != ' ') {
        reachedLetter = true;
        break;
    }
    index++;
}
int leftFirstLetter = index;
index = 0;
reachedLetter = false;
while (true) {
    if (sentence1[sentence1.Length - index - 1] != ' ') {
        reachedLetter = true;
        break;
    }
    index++;
}
int rightFirstLetter = sentence1.Length - index - 1;

for (int i = leftFirstLetter; i < rightFirstLetter + 1; i++) {
    sentence2 += sentence1[i];
}
Console.WriteLine($"Trimmed sentence: {sentence2}");
*/
#endregion

#region Task5
/*
// Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.

char[] symbolArray = new char[4] { '+', '*', '-', '/' };

Console.WriteLine("Please enter the first number");
double number1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the second number");
double number2 = double.Parse(Console.ReadLine());

char operation;
bool isThere = false;
do {
    Console.WriteLine("Please choose an operation between (+, -, *, /)");
    operation = char.Parse(Console.ReadLine());

    for (int i = 0; i < symbolArray.Length; i++) {
        if (operation == symbolArray[i]) {
            isThere = true;
            break;
        }
    }
} while (!isThere);
switch (operation) {
    case '+':
        Console.WriteLine(number1 + number2);
        break;
    case '-':
        Console.WriteLine(number1 - number2);
        break;
    case '/':
        Console.WriteLine(number1 / number2);
        break;
    case '*':
        Console.WriteLine(number1 * number2);
        break;
    default:
        break;
}
*/
#endregion