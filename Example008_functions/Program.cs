int Max (int arg1, int arg2, int arg3) 
{
int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}

int a1 = 14;
int b1 = 3;
int c1 = 25;
int a2 = 121;
int b2 = 44;
int c2 = 56;
int a3 = 11;
int b3 = 4636;
int c3 = 34;


int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

/* Пример вложенности функций при Функциональном программировании

int maxmax = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
*/

int maxmax = Max(max1, max2, max3);


Console.WriteLine(maxmax);