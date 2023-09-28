System.Console.WriteLine("Введите день недели");
int num = int.Parse(Console.ReadLine());
if (num >= 6 && num < 8){
    Console.WriteLine("это выходной");
}
if (num >= 1 && num < 7){
    Console.WriteLine("Это будни");
}
