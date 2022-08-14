double Cube (int num){
    double i = 1;
    double Out = 0;
    if(num>=1){
    do {
        Out=Math.Pow(i,3);
        Console.WriteLine(Out);
        i++;
    }while(i<=num);
    }
    return Out;
}

Console.Write("Введите число: \n");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Таблица кубов чисел от 1 до " + N + ":\n");
Cube(N);