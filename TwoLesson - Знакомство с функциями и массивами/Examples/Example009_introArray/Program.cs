int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array = {1, 2, 3, 31, 51, 5, 6, 523, 18 };


// int a1 = 15, b1 = 21, c1 = 39, 
//     a2 = 12, b2 = 23, c2 = 33, 
//     a3 = 13, b3 = 23, c3 = 33;

// int max1 = Max(a1, b1, c1); 
// int max2 = Max(a2, b2, c2); 
// int max3 = Max(a3, b3, c3); 

int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])); 
    
Console.WriteLine(max);

