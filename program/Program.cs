string[]array = {"day", "manth", "if"};
int i = 0; 
int k = 3;
int n = array.Length;
while (i < n)
{
    if (array[i].Length <= k)
    {
        Console.Write(array[i] + " ");
    }
    i= i + 1;
}