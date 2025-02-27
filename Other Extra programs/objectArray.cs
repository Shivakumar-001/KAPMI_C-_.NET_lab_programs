using System;
class y{}
class z{}
class GFG
{
    public static void Main(String[] args)
    {
        object[] o = new object[5];
        o[0]=new y();
        o[1]=new z();
        o[2]="Hello";
        o[3]=4759.0;
        o[4]=null;
        for(int q=0;q<o.length;++q)
        {
            String str1 = o[q] as string;
            Console.WriteLine("{0}",q);
            if(str1!=null)
            {
                Console.WriteLine("'"+ str1 +"'");
            }
            else
            {
                Console.WriteLine("Is this not a string");
            }
        }
    }
}