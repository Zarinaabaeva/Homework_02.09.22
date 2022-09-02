Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if(a == 6 || a == 7){
    Console.WriteLine("выходной");
}
else if(a < 1 || a > 7){
    Console.WriteLine("это не день недели");
}   
else{
    Console.WriteLine("не выходной");
}     
