using System;

namespace Manhattan3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Height (number of rows) in the 2 dimensional array: ");
            int.TryParse(Console.ReadLine(), out int rows);
            Console.Write("Please enter the width (number of columns) in the 2 dimensional array: ");
            int.TryParse(Console.ReadLine(), out int columns);
            Console.Write("Please enter the reference Height (row or y axis) in the 2 dimensional array: ");
            int.TryParse(Console.ReadLine(), out int refRow);
            Console.Write("Please enter the reference Width (column or x axis) in the 2 dimensional array: ");
            int.TryParse(Console.ReadLine(), out int refColumn);
            Console.Write("Please enter the Manhattan distance for neighbors in the 2 dimensional array: ");
            int.TryParse(Console.ReadLine(), out int distance);

            //int rows = 11;
            //int columns = 11;
            //int refRow = 5;
            //int refColumn = 5;
            //int distance = 3;

            CountGridCellNeighbors(rows, columns, refRow, refColumn, distance);
            
        }

        public static int[][] CountGridCellNeighbors(int rows, int columns, int refRow, int refColumn, int distance)
        {
            int numberRows = rows - 1, numberColumns = columns - 1;
            // find max distance to all 4 corners of the matrix
            var maxd = Math.Max(Math.Max(refRow + refColumn, numberRows - refRow + refColumn), Math.Max(numberRows - refRow + numberColumns - refColumn, refRow + numberColumns - refColumn));
            
            var array = new int[rows * columns][];
            var index = 0;
            array[index++] = new[] { refRow, refColumn };
            
            // count valid points inserted
            var count = 1;

            for (var i = 1; i <= distance && i <= maxd; i++)          
            {

                // calculate row top and bottom caps
                var rowTop = Math.Max(0, refRow - i);
                var rowBottom = Math.Min(numberRows, refRow + i);

                for (int r = rowTop; r <= rowBottom; r++)
                {

                    // calculate current distance to center
                    var d = Math.Abs(refRow - r);
                    // based on that we calculate column value for the cell to the left
                    var ci = i - d;
                    var c = refColumn - ci;

                    // if this is a valid point then insert it
                    if (c >= 0)
                    {
                        array[index++] = new[] { r, c, };
                        count++;
                      
                    }

                    // if we are not processing the top point (center) then find the right point
                    if (ci > 0)
                    {
                        c = refColumn + ci;

                        // if this is a valid point then insert it
                        if (c < columns)
                        {
                            array[index++] = new[] { r, c, };
                            count++;
                           
                        }
                    }

                }

            }
            Console.WriteLine($"There are {count} cells in the N = {distance} neighborhood.");
            
            return array;
        }
      
    }
     
}
