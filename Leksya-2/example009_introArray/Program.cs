int a1 = 1;
int b1 = 4;
int c1 = 55;
int a2 = 44444;
int b2 = 93;
int c2 = 8986324;
int a3 = 432;
int b3 = 832;
int c3 = 93;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1 ;
    if (arg2 > result ) result = arg2;
    if (arg3 > result ) result = arg3;
    return result;
}

int [] array = {11, 22, 33, 444, 55, 66, 77, 88, 99, } ;

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max) ;