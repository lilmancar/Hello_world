int a = 3;
int b = 2;
int h = 10;
int day = 1; 
h = h - 3;
while (h > 0)
{
  h = h - a + b;
  day = day + 1;
}
 Console.WriteLine(day);