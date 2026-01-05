using System;

class typecast
{
    static void Main()
    {
        /*float n1 = 3.14f;
        int n2 = (int)n1;//typecast de float para int*/

        int vInt =10;
        short vShort = (short)vInt;//conversão implícita de int para short

        Console.WriteLine(vShort);
    }
}