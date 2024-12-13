using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            //String : Is A Class [Reference Type] Internally Is An Arry Of Chars
            //int x = 0;
            //int y = 10;
            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y.GetHashCode());
            //x = y;
            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y.GetHashCode());
            //StringBuilder sb = new StringBuilder();

            #endregion

            #region string builder 
           
            //    StringBuilder message;
            //message = new StringBuilder("hello");
            //  Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"the hashcpde is {Message.heshcode()}");
            ////Message append("ali);

            //Console.WriteLine($"Message:{Message}");
            //Console.WriteLine($"the hashcpde is {Message.heshcode()}");

            #endregion

            #region 1D Array
            //int[] num01 =new int [3]{6,2,3 };
            //  int[] num02 =new int []{1,2,3 };
            //int[] num03 = {1,2,3, };
            //Console.WriteLine(num01[0]);
            //Console.WriteLine(num01[1]);
            //Console.WriteLine(num01[2]);
            //Console.WriteLine($"len:{num01.Length}: rank: {num01.Rank}");
            ////----
            //foreach( int num in num01 )
            //{
            //    Console.WriteLine( num );
            //}
            #endregion

            #region 2D Array
            //int[,] a = new int[3, 5];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"please enter the grades for student{i+1}");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine($"please enter the grades for subject{j + 1}");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            #endregion
        }
    }
}
