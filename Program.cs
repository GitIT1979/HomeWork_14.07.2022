// 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] GetArray(int m, int n, int min, int max) // Создание пользовательского массива
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max); 
//         }
//     }
//     return result;
// }

//     void PrintArray (int[,] array)   // Вывод пользовательского массива на экран
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//             Console.Write($"{array[i, j]} ");
//             }    
//         Console.WriteLine();
//         }
//     }   

//     void SortArray(int[,] array) // Сортировка строк массива по убыванию
//     {
//             for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int[] temp = new int[array.GetLength(1)]; // Создание временного массива для его заполнения строкой двумерного массива
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 temp[j] = array[i,j];  // Заполнение одномерного массива значениями строки двумерного массива
//                 if (j == array.GetLength(1) - 1)
//                 {
//                     Array.Sort(temp);
//                     Array.Reverse(temp); // Сортировка одномерного массива по убыванию
//                     for (int k = 0; k < array.GetLength(1); k++)
//                     {   
//                         array[i,k] = temp[k]; // Заполнение строки двумерного массива значениями 
//                                               // отсортированного по убыванию одномерного массива
//                     }
//                 }
//             }
//         }
//     }
      
// Console.WriteLine("Input the amount of rows in the massive: ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the amount of columns in the massive: ");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine("Input minimum mean in the massive: ");
// int minimum = int.Parse(Console.ReadLine());
// Console.WriteLine("Input maximum mean in the massive: ");
// int maximum = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,]myArray = GetArray (rows, columns, minimum, maximum);
// PrintArray(myArray);
// SortArray(myArray);
// Console.WriteLine();
// PrintArray(myArray);

// 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int[,] GetArray(int m, int n, int min, int max) // Создание пользовательского массива
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray (int[,] array)   // Вывод пользовательского массива на экран
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//             Console.Write($"{array[i, j]} ");
//             }    
//         Console.WriteLine();
//         }
//     }   

// int[] SumRowsArray(int[,] array) // Перемещение сумм элементов строк двумерного массива в массив
// {
//     int[] result = new int[array.GetLength(1)];
            
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum += array[i,j];
//                 if (j == array.GetLength(1) - 1) 
//                 {
//                     result[i] = sum;
//                 }
//             }
//         }
//     return result;
// }

// void MinMeanArray(int[] array) // Определение номера минимального по значению элемента массива
// {
// int min = array[0];
// int minIndex = 0; 
// for (int i = 1; i < array.Length; i++)
// {
//     if (min > array[i]) 
//     {
//         min = array[i]; 
//         minIndex = i;
//     }
// }
// Console.WriteLine ($"The row containing minimal sum of its elements is {minIndex}.");
// }
      
// Console.WriteLine("Input the amount of rows in the massive: ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the amount of columns in the massive: ");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine("Input minimum mean in the massive: ");
// int minimum = int.Parse(Console.ReadLine());
// Console.WriteLine("Input maximum mean in the massive: ");
// int maximum = int.Parse(Console.ReadLine());

// Console.WriteLine();
// int[,]myArray = GetArray(rows, columns, minimum, maximum);
// PrintArray(myArray);
// int[]newArray = SumRowsArray(myArray);
// MinMeanArray(newArray);
//

// 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] GetArray(int m, int n, int min, int max) // Создание пользовательской матрицы
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// int[,] MultiMatrix(int[,]Matrix1, int[,]Matrix2) // Создание матрицы - результата перемножений матриц
// {
//     int m = Matrix1.GetLength(0);
//     int n = Matrix2.GetLength(1);
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 for (int k = 0; k < m; k++)
//                 {
//                     result[i,j] += Matrix1[i,k] * Matrix2[k,j];
//                 }
//             }
//         }
//     return result;
// }

// void PrintArray (int[,] array)   // Вывод пользовательского массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }    
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input the amount of rows in the 1st matrix: ");
// int rows1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the amount of columns in the 1st matrix: ");
// int columns1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Iput the amount of rows in the 2nd matrix: ");
// int rows2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the amount of columns in the 2nd matrix: ");
// int columns2 = int.Parse(Console.ReadLine());
// if (columns1 != rows2 ) Console.WriteLine("It is impossible to multiply matrices!");
// else
// {
//     Console.WriteLine("Input minimum values in the matrices: ");
//     int minimum = int.Parse(Console.ReadLine());
//     Console.WriteLine("Input maximum values in the matrices: ");
//     int maximum = int.Parse(Console.ReadLine());

//     Console.WriteLine();
//     int[,]matrix1 = GetArray (rows1, columns1, minimum, maximum);
//     int[,]matrix2 = GetArray (rows2, columns2, minimum, maximum);
//     PrintArray(matrix1);
//     Console.WriteLine();
//     PrintArray(matrix2);
//     Console.WriteLine();
//     Console.WriteLine("The result of multiplication of matrices is: ");
//     Console.WriteLine();
//     int[,]multiMatrix = MultiMatrix(matrix1, matrix2);
//     PrintArray(multiMatrix);
//     Console.WriteLine();
// }

// 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[] GetUniqueArray(int m, int n, int l) // Создание пользовательского массива из неповторяющихся двузначных чисел
// {
//     int[] array = new int[m * n * l];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10, 100);
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (array[i] == array[j])
//                 {
//                     array[i] = new Random().Next(10, 100);
//                     j = 0;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int[,,] GetUnique3DArray(int m, int n, int l, int[] array) // Преобразование пользовательского массива из неповторяющихся 
//                                                             // двузначных чисел в 3D массив
// {
//     int[,,] result = new int[m, n, l];
//     int count = 0;
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < l; k++)
//             {
//                 result[i, j, k] = array[count];
//                 count++;
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,,] array)   // Вывод пользовательского 3d массива на экран построчно с отображением индекса
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) "); 
//                 if (k == array.GetLength(2) - 1)  Console.WriteLine();
//             }   
//         }
//      }
// }   

// Console.WriteLine("Input the size of the 1st dimension of the massive: ");
// int d1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the size of the 2nd dimension of the massive: ");
// int d2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the size of the 3rd dimension of the massive: ");
// int d3 = int.Parse(Console.ReadLine());
// Console.WriteLine();

// int[] tempArray = GetUniqueArray (d1, d2, d3);
// int[,,]myArray = GetUnique3DArray(d1, d2, d3, tempArray);
// PrintArray(myArray);

// 5. Заполните спирально массив 4 на 4.

// int [,] GetSpiralArray() // Создание спирального массива
// {
//     int rows = 4;
//     int columns = 4;
//     int[,] array = new int[rows, columns]; 
//     for (int j = 0; j < array.GetLength(1); j++) array[0, j] = j + 1;
//     for (int i = 1; i < array.GetLength(0); i++)  array[i, 3] = i + 4;
//     for (int j = 2; j > -1; j--) array[3, j] = -1 * (j - 10);
//     for (int i = 2; i > 0; i--) array[i, 0] = -1 * (i - 13);
//     for (int j = 1; j < 3; j++) array[1, j] = j + 12;
//     for (int i = 2; i > 0; i--) array[2, i] = -1 * (i - 17);
//     return array;
// }

// void PrintArray (int[,] array)   // Вывод массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//          Console.Write($"{array[i, j]} ");
//         }    
//     Console.WriteLine();
//     }
// }   

// int[,]myArray = GetSpiralArray();
// // GetSpiralArray(myArray);
// PrintArray(myArray);

// 6. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// int[,] GetArray(int m, int n) // Создание пользовательского массива
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(31, 51);
//         }
//     }
//     return result;
// }

// void PrintArray (int[,] array)   // Вывод пользовательского массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }    
//         Console.WriteLine();
//     }
// }   

// int[] FreqList(int [,] array, int temp = 0)
// {
//     int A = 20; // Разница между максимальным и минимальным значениями массива
//     int differ = 30; // Разница между минимальным значением массива и единицей
//     int[] array1 = new int[A];
//     if (temp < A)
//     {
//         array1[temp] = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] == temp + differ + 1) array1[temp]++;
//             }
//         }
//     }
//     temp +=1;
//     if (temp > A) return array1;
//     Console.WriteLine($"{temp + differ} occurs in the massive {array1[temp-1]} times.");
//     return FreqList(array, temp++);
//    }

// Console.WriteLine("Input the amount of rows in the massive: ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the amount of columns in the massive: ");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine();
// int[,]myArray = GetArray(rows, columns);
// PrintArray(myArray);
// Console.WriteLine();
// FreqList(myArray, 0);
// Console.WriteLine();

// 7. Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// int[,] GetArray(int m, int n, int min, int max) // Создание пользовательского массива
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void PrintArray (int[,] array)   // Вывод пользовательского массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//          }    
//         Console.WriteLine();
//     }
// }

// int [] MinArray(int[,] array) // Нахождение первого минимального значения элемента в массиве.
// {
//     int min = array[0,0];
//     int [] resultArray = new int[2];
//         for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (min > array[i, j])
//             {
//                 min = array[i, j];  
//                 resultArray[0] = i; 
//                 resultArray[1] = j; 
//             }       
//         }
//     }
//     Console.WriteLine($"Minimal value of the massive is {min} (row - {resultArray[0] + 1}, column - {resultArray[1] + 1}).");
//     Console.WriteLine();
//     return resultArray;
// }

// int[,] ModArray(int[,] array, int [] array1) // Создание массива без строки и столбца, содержащие минимальный 
//                                             // по значению элемент массива.
// {
//     int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int a = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int b = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array1[0] != i && array1[1] != j)
//             {   result[a, b] = array[i, j];
//                 b++;
//             }
//         }
//         if (array1[0] != i) a++;
//     }
//     return result;
// }

// Console.WriteLine("Input the amount of rows in the massive: ");
// int rows = int.Parse(Console.ReadLine());
// Console.WriteLine("Input the amount of columns in the massive: ");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine("Input minimum mean in the massive: ");
// int minimum = int.Parse(Console.ReadLine());
// Console.WriteLine("Input maximum mean in the massive: ");
// int maximum = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,]myArray = GetArray (rows, columns, minimum, maximum);
// PrintArray(myArray);
// Console.WriteLine();
// int[,]resultArray = ModArray(myArray, MinArray(myArray));
// PrintArray(resultArray);
// Console.WriteLine();

// 8. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

// int[,] GetPascalTriangle(int N) // Создание двумерного массива, включающего в себя значения треугольника Паскаля
// {
//     int[,] PascalTriangle = new int [N, N * 2 + 1];

//     for (int k = 0; k < PascalTriangle.GetLength(0); k++) PascalTriangle[k, 0] = 1;
//     for (int i = 1; i < PascalTriangle.GetLength(0); i++)
//     {
//         for (int j = 1; j < i + 1; j++) PascalTriangle[i, j] = PascalTriangle[i - 1, j] + PascalTriangle[i - 1, j - 1];
//     }
//     return PascalTriangle;
// }

// void ModPascalTriangle(int[,] array) // Переводить значения элементов треугольника Паскаля для треугольного их размещения
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int count = 0;
//         for (int j = array.GetLength(1) - 1; j >= 0; j--)
//         {
//             if (array[i, j] != 0)
//             {
//                 array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
//                 array[i, j] = 0;
//                 count++;
//             }
//         }
//     }
// }

// void ZeroSpacePrintArray(int[,] array) // Производит вывод массива на экран с заменой нулей на пробелы
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i, j] != 0)
//       {
//           Console.Write($"{array[i, j]} ");
//       }
//       else Console.Write("  ");
//     }
//     Console.WriteLine();
//   }
// }

// Console.WriteLine("Input the amount of rows in Pascal's triangle: ");
// int rows = int.Parse(Console.ReadLine());

// int[,] PascalTriangle = GetPascalTriangle(rows);
// Console.WriteLine();
// ModPascalTriangle(PascalTriangle);
// ZeroSpacePrintArray(PascalTriangle);
// Console.WriteLine();
