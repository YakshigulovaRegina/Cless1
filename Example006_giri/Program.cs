int num1 = 1;
int num2 = 2;
int num3 = 6;
int num4 = 8;
int num5 = 4;

int max = num1;

if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
if(num4 > max) max = num4;
if(num5 > max) max = num5;

Console.Write("max = ");
Console.WriteLine(max);