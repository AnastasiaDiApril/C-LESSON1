int[] array = {1, 2, 5, 18, 93, 10, 45, 19, 89, 93};

int n = array.Length;
int find = 93;

int index = 0;

while(index < n){

    if(array[index] == find){

        Console.WriteLine(index);
        break;
    }
    index++;
}
