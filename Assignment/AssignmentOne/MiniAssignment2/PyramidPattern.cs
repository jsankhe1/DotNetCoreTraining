namespace Assignment.MiniAssignment2;

/*Create a program to print the following pattern:
    ```
*
***
*****
*******
*********
    ```  */
public class PyramidPattern
{
    public void printPyramid()
    {
        int totalRows = 5;
        {
            for (int i = 0; i < totalRows; i++)
            {
                //print spaces
                for (int j = 0; j < totalRows-i-1 ; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}