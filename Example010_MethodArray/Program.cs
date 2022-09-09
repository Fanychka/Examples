

int[] array = {11,2,13,4,15,61,17,8};

int n = array.Length;

int find = 7;
int index = 0;

while (index < n) 
{
if(array[index] == find)
    {
    Console.WriteLine(index);
    }
index = index++;
}

