
int Shach (int num){

string str = ""+num;
char [] ar = str.ToArray<char>();

int l=ar.Length-1;
int i=0;
var a=0;
var b =0;
int ci=0;
do {
        a = (int)Char.GetNumericValue(ar[l]);
        b = (int)Char.GetNumericValue(ar[i]);
        if (a==b){
        ci ++ ;
        }
    l--;
    i++;
}while (ar.Length-1>=i);
if (ci == ar.Length){
    return ci;
 }else{
    return 0;
 }
 }


Console.Write("Введите число: \n");
int N = Convert.ToInt32(Console.ReadLine()!);

if (Shach(N)<=0){
    Console.Write("Число не является палиндромом");
}else{
    Console.Write("Число является палиндромом");
}