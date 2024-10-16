namespace ConsoleApp9
{

  //public delegate int stringfuncdelegate(string name);
    internal class Program
    {
        //public static int getcountofupperstrfunc(string name) {
        //    int count = 0;


        //        if(name != null)
        //        for(int i = 0; i < name.Length; i++)
        //        {
        //            if (char.IsUpper(name[i]))
        //            {
        //                count++;
        //            }
        //        }
        //    return count;
        
        //}
        //public static int getcountoflowerstrfunc(string name)
        //{
        //    int count = 0;


        //    if (name != null)
        //        for (int i = 0; i < name.Length; i++)
        //        {
        //            if (char.IsLower(name[i]))
        //            {
        //                count++;
        //            }
        //        }
        //    return count;

        //}

        static void Main(string[] args)
        {

            //string[] name = { "ebrahem", "mohamed", "ali", "khaled", "mabrouk" };
            //bubblesort<String> .bubllsort(name, comparefuncton.funcgrtstring);
            //foreach (string names in name)
            //{
            //    Console.WriteLine(names);
            //}

            //int[] number = { 1, 20, 4, 6, 7, 0, 9, 2, 5 };

            //bubblesort.bubllsort(number, comparefuncton.funcless);

            //foreach ( int numbers in number)
            //{
            //    Console.WriteLine(numbers);
            //}
            //stringfuncdelegate stringfunc;
            //stringfunc = getcountofupperstrfunc;
            //stringfunc +=getcountoflowerstrfunc;

            //int result = stringfunc.Invoke("ebrahem");

            //Console.WriteLine(result);
            // List<int> number = Enumerable.Range(0, 100).ToList();
            //List<int>oddnumber=bubblesort.getelmentbyallpramters(number,logicfunction.elmenteven, result);
            // foreach (int num in oddnumber) {
            //     Console.Write(num+" ");
            // }
            List<string> name = new List<string>() { "ebrahem", "ali", "mona", "ahmed", "aya", "sayed " };

            List<string> nameoflengthfour = bubblesort.getelmentbyallpramters(name, logicfunction.getelmentlfour);
            foreach (string names in nameoflengthfour)
            {
                Console.WriteLine(names);
            }


        }
    }
}
