using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            //Правя Матрицата и я пълня с елементите
            char[][] matrix = CreateMatrix(rows);

            int samRow = -1;
            int samCol = -1;

            int nikRow = -1;
            int nikCol = -1;

            //Намирам позициите на Сам и Николадзе
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;

                        matrix[row][col] = '.';
                    }
                    else if (matrix[row][col] == 'N')
                    {
                        nikRow = row;
                        nikCol = col;
                    }
                }
            }

            //Правя два флага за да знам кога да приключа програмата
            bool IsSamDead = false;
            bool isNicDead = false;

            string input = Console.ReadLine();



            for (int i = 0; i < input.Length; i++)
            {
                char direction = input[i];

                //Още преди да преместя Сам, местя всички врагове и, ако се налаги ги обръщам
                MoveEnemies(matrix);

                //Проверка дали, ако някой от враговете се е обърнал не е видял Сам, и ако е то тогава Сам е мъртъв
                // и програмата приключва
                if (IsSamKilled(matrix, samRow, samCol))
                {
                    IsSamDead = true;
                    break;
                }

                int samNextRow = samRow;
                int samNextCol = samCol;

                //Променям позицията на Сам спрямо инструкциите
                switch (direction)
                {
                    case 'U':
                        samNextRow--;
                        break;
                    case 'D':
                        samNextRow++;
                        break;
                    case 'L':
                        samNextCol--;
                        break;
                    case 'R':
                        samNextCol++;
                        break;
                    case 'W':
                        continue;

                }

                //Проверявам дали Сам не е достигнал реда на Николадзе, ако е Николадзе е мъртъв и програмата 
                //приключва
                if (samNextRow == nikRow)
                {
                    isNicDead = true;
                    samRow = samNextRow;
                    samCol = samNextCol;
                    break;
                }

                //След като съм преместил позицията на Сам, отново проверявам дали някой от враговете не гледа към
                //него и, ако е така приключвам програмата, ако не, проверявам дали Сам не е на една и съща позиция
                //с някой от враговете и убивам врага
                if (IsSamKilled(matrix, samNextRow, samNextCol))
                {
                    IsSamDead = true;
                    samRow = samNextRow;
                    samCol = samNextCol;
                    break;
                }
                else
                {
                    KillEnemy(matrix, samNextRow, samNextCol);
                }

                //Обновявам позицията на Сам
                samRow = samNextRow;
                samCol = samNextCol;
            }



            if (IsSamDead)
            {
                matrix[samRow][samCol] = 'X';
                Console.WriteLine($"Sam died at {samRow}, {samCol}");
            }
            else
            {
                matrix[nikRow][nikCol] = 'X';
                matrix[samRow][samCol] = 'S';
                Console.WriteLine("Nikoladze killed!");
            }


            PrintMatrix(rows, matrix);
        }

        private static void KillEnemy(char[][] matrix, int samNextRow, int samNextCol)
        {
            if (matrix[samNextRow][samNextCol] == 'b' || matrix[samNextRow][samNextCol] == 'd')
            {
                matrix[samNextRow][samNextCol] = '.';
            }
        }

        private static bool IsSamKilled(char[][] matrix, int samRow, int samCol)
        {
            bool isSamDead = false;

            if (matrix[samRow].Any(x => x == 'b'))
            {
                int enemyIndex = GetEnemyIndex(matrix[samRow], 'b');

                if (enemyIndex < samCol)
                {
                    isSamDead = true;
                }
            }
            else if (matrix[samRow].Any(x => x == 'd'))
            {
                int enemyIndex = GetEnemyIndex(matrix[samRow], 'd');

                if (enemyIndex > samCol)
                {
                    isSamDead = true;
                }
            }

            return isSamDead;
        }

        private static int GetEnemyIndex(char[] samRow, char enemy)
        {
            int enemyIndex = -1;

            for (int i = 0; i < samRow.Length; i++)
            {
                if (samRow[i] == enemy)
                {
                    enemyIndex = i;
                }
            }

            return enemyIndex;
        }

        private static void MoveEnemies(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'b')
                    {
                        if (col == matrix[row].Length - 1)
                        {
                            matrix[row][col] = 'd';
                        }
                        else
                        {
                            matrix[row][col] = '.';
                            matrix[row][col + 1] = 'b';

                            break;
                        }
                    }
                    else if (matrix[row][col] == 'd')
                    {
                        if (col == 0)
                        {
                            matrix[row][col] = 'b';
                        }
                        else
                        {
                            matrix[row][col] = '.';
                            matrix[row][col - 1] = 'd';

                            break;
                        }
                    }
                }
            }
        }

        private static void PrintMatrix(int rows, char[][] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join("", matrix[row]));
            }
        }

        private static char[][] CreateMatrix(int rows)
        {
            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                matrix[row] = currentRow.ToCharArray();
            }

            return matrix;
        }
    }
    
}
