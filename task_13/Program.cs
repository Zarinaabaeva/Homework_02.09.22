Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int x = a / 100 % 10;
if(a / 100 > 0){
    Console.WriteLine(x);
}
else{
    Console.WriteLine("третьей цифры нет");
}

