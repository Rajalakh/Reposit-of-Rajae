using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;



namespace ConsoleApplication1
{
    class Program
    {
        static int[,] grid = new int[9, 9];
        static string s;
        static void Init(ref int[,], grid)
        {
            for (int i =0; i < 9; i++)

            {
                for (int j =0; j < 9; j++)
                {
                    grid[i, j] = (i * 3 + i / 3 + j) % 9 + i;
                }
 }
static void Draw(ref int[,]  grid, out string _s)
{
    for (int x =0; x < 9; x++)
     {
        for (int y = 0; y < 9; y++)
        {
             s += grid[x, y].ToString() + " ";
         }
     }
               
                Console.WriteLine(s);
                _s = s;
                s = "";
 }

 static void ChangeTwoCell(ref int[,] grid, int findValue1, int findvalue2)

}
        int xParam1, yParam1, xParam2, yParam2;
        xParam1 = yParam1 = xParam2 =yParam2 = 0;
        for (int i = 0; i < 9; i+=3)
        {
            for (int k =0; k< 9; k+=3)
            {
                 for (int j =0; j<3; j++)
                 {
                      for (int z =0; z < 3; z++)
                      {

                           if (grid[i + j, K + z] == findValue1)
                            
                           {
                                xParam1 = i + j;
                                yParam1 = K + z;
                    
                            }
                            if (grid[i + j, K + z] == findValue2)

                            {
                                xParam2 = i + j;
                                yParam2 = K + z; 
                            }
                        }
                    }
static void update(ref int[,] grid, int shufflelevel)
{
    for (int repeat = 0; repeat < shufflelevel; repeat++)
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        Random rand2 = new Random(Guid.NewGuid().GetHashCode());
        changeTwocell(ref grid, rand, Next(1, 9), rand2.Next(1, 9));
    }
}
[STAThread]
static void Main(string[] args)
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    s = "";
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        s = "";
        string ç1kt1;
        TypeInitializationException(ref grid);
        update(ref grid, 10);
        Draw(ref grid, out ç1kt1);
        System.Windows.Forms.Clipboard.SetText(ç1kt1);
        Console.ReadKey();
























































