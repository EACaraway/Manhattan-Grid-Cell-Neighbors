# Manhattan-Grid-Cell-Neighbors
Assumptions
1. You have a two-dimensional array in which every element (cell) contains a single, signed
number.
a. Assume the height of the array (the number of rows) is H , and that H > 0.
b. Assume the width of the array (the number of columns) is W , and that W > 0.
c. For this exercise, it does not matter what sort of number the cells contain; it's
only important which values are positive or not.
d. Assume cell locations are written here as (Y, X) or (row, column).
2. You have a distance threshold, N , and you can assume N ≥ 0.
3. Assume you are using a Manhattan distance function. From (2,1) to (0,4) would be the
sum of the differences in the two dimensions: |2-0| + |1-4| = 2 + 3 = 5
4. For the purposes of the initial exercise, the array dimensions do not wrap. That is, the
first column should not be considered adjacent to the last column (unless W < 3), and
the top row should not be considered adjacent to the bottom row (unless H < 3).

The task
The task is to write a routine that will return the number of cells that fall within N steps of any
positive values in the array. Note:
1. Each cell in the neighborhood should be counted only once, no matter how many
positive values it is near. (There is a specific example of this case later.)
2. The cell containing the positive value should also count (as a 0-distance member) as
part of its own neighborhood.
3. You may use any language you like, but it should be able to run. That is, please do not
merely provide a pseudo-code sketch of how you would solve the problem.
