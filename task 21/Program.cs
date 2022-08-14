double Distance3DObject (double y1, double x1, double z1, double y2, double x2, double z2){
double num = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
return num;
}
Console.WriteLine("Растояние между обьектами: " + Distance3DObject (3,6,8,2,1,-7));
Console.WriteLine("Растояние между обьектами: " + Distance3DObject (7,-5,0,1,-1,9));