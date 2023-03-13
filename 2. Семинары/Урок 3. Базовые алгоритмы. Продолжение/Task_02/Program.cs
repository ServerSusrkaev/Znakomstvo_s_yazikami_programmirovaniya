int [] array = new int [5] {1, 3, 1, 2, 1};
int [] old = new int [1] {0};

//int i = 0;
int l = 1;
int count = 0;
//int length = 0;

    for (int i = 0; i < array.Length; i++)
    {
       for (int n = 0; n < old.Length; n++)
       {
            if (array[i] != old[n])
            {
                for (int j = i; j < array.Length; j++)
                {
                    if(array[j] == array[i]) {count++;}
                }
                Console.WriteLine(array[i] + " - " + count);
                count = 0;
            for (l = 1; l < old.Length; l++)
            {
                old[l] = array[i];
            }
            }
       }
    Array.Resize(ref old, old.Length + l); 
    }