Main();

void Main()
{
    bool isWorking = true;
    while(isWorking){
        Console.WriteLine("Input task");
        string task = Console.ReadLine();

        switch(task){
            case "exit": isWorking = false; break;
            case "t10": Task10(); break;
            case "t13": Task13(); break;
            case "t15": Task15(); break;
            default: break;
        }
    }
}

// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
void Task10(){
    int number = ReadInt("трехзначное число");
    string numStr = number.ToString();
     if (number >= 100 && number < 1000){
        Console.WriteLine(numStr[1]);
     }
     else {
        Console.WriteLine("Ввели не трехзначное число");   
     }
}

// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
void Task13(){
    int number = ReadInt("number");
    string numStr = number.ToString();
    int lenStr = numStr.Length;

    if (lenStr < 3){
         Console.WriteLine("Третьей цифры нет");
    } else{
        Console.WriteLine(numStr[2]);
    }
}

// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
void Task15(){
    int day = ReadInt("day");

    switch (day)
    {
        case 1: Console.WriteLine("понедельник");break;
        case 2: Console.WriteLine("вторник"); break;
        case 3: Console.WriteLine("среда"); break;
        case 4: Console.WriteLine("четверг"); break;
        case 5: Console.WriteLine("пятница"); break;
        case 6: Console.WriteLine("суббота - выходной день"); break;
        case 7: Console.WriteLine("воскресенье - выходной день"); break;
        default: Console.WriteLine("не верный день недели"); break;
    }
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Input {argument}:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}