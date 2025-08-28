#1

// Using for loop
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

// Using while loop
int j = 10;
while (j >= 1)
{
    Console.WriteLine(j);
    j--;
}

// Using do-while loop
int k = 10;
do
{
    Console.WriteLine(k);
    k--;
} while (k >= 1);


#2

// Using for loop
for (int i = 1; i <= 50; i += 2)
{
    Console.Write(i + " ");
}

// Using while loop
int j = 1;
while (j <= 50)
{
    Console.Write(j + " ");
    j += 2;
}

// Using do-while loop
int k = 1;
do
{
    Console.Write(k + " ");
    k += 2;
} while (k <= 50);


#3

int baseNum = 2, exponent = 5; 
int result;

// Using for loop
result = 1;
for (int i = 1; i <= exponent; i++)
{
    result *= baseNum;
}
Console.WriteLine("Result (for): " + result);

// Using while loop
result = 1;
int j = 1;
while (j <= exponent)
{
    result *= baseNum;
    j++;
}
Console.WriteLine("Result (while): " + result);

// Using do-while loop
result = 1;
int k = 1;
do
{
    result *= baseNum;
    k++;
} while (k <= exponent);
Console.WriteLine("Result (do-while): " + result);


#4

// Using for loop
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i * i;
}
Console.WriteLine("Sum of squares (for): " + sum);

// Using while loop
sum = 0;
int j = 1;
while (j <= 10)
{
    sum += j * j;
    j++;
}
Console.WriteLine("Sum of squares (while): " + sum);

// Using do-while loop
sum = 0;
int k = 1;
do
{
    sum += k * k;
    k++;
} while (k <= 10);
Console.WriteLine("Sum of squares (do-while): " + sum);


#5

int num = 123456789;
int sum;

// Using for loop (by converting to string)
sum = 0;
string strNum = num.ToString();
for (int i = 0; i < strNum.Length; i++)
{
    int digit = strNum[i] - '0';
    if (digit % 2 != 0)
        sum += digit;
}
Console.WriteLine("Sum of odd digits (for): " + sum);

// Using while loop
sum = 0;
int temp = num;
while (temp > 0)
{
    int digit = temp % 10;
    if (digit % 2 != 0)
        sum += digit;
    temp /= 10;
}
Console.WriteLine("Sum of odd digits (while): " + sum);

// Using do-while loop
sum = 0;
temp = num;
do
{
    int digit = temp % 10;
    if (digit % 2 != 0)
        sum += digit;
    temp /= 10;
} while (temp > 0);
Console.WriteLine("Sum of odd digits (do-while): " + sum);
