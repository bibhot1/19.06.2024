




int[,] array2DInitialized = { { 1, 2 },{3, 4 } };

// this array gonna look like this 


// [1] [2]
// [3] [4]

// lets check on the console and get the value of the array at certain position

Console.WriteLine(array2DInitialized[0, 0]);
// so this will get us the value of 1

Console.WriteLine(array2DInitialized[0, 1]);
// so thats 2
Console.WriteLine(array2DInitialized[1, 0]);
// thats 3
Console.WriteLine(array2DInitialized[1, 1]);
// thats 4


// thats a 2d array 

// lets override some of the value on our 2d array

array2DInitialized[1, 1] = 12;
Console.WriteLine(array2DInitialized[1, 1]);