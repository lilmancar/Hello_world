int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA * numberA);
int i = 0;
while (i < 2015){
    numberA = numberA * numberA;
    i++;
}