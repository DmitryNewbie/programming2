Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
if(num >= 100 && num <=1000 ){
    Console.WriteLine($"{num % 100 / 10} Второе число");
}
else{
    System.Console.WriteLine($"Ваше число не {num} не трехзначное");
}