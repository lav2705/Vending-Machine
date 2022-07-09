using System;

using Vending_Machine_name;

 static void Main(string[] args)
{
    int val = 0;
    Vending_Machine_name.Vending_Machine vend = new Vending_Machine_name.Vending_Machine();
    vend.insertproduct("cola", 1.00);
    vend.insertproduct("chips",0.50);
    vend.insertproduct("candy",0.65);
    while(val!=-1)
    {;
        Console.WriteLine("*******Vending machine ***********");
        if(vend.getcurrentvalue()==0)
        {
            Console.WriteLine("Insert coin");
            double getcoin = Convert.ToDouble(Console.ReadLine());
            vend.insertcoin(getcoin);
        }
        else
        {
            Console.WriteLine("current inserted value", vend.getcurrentvalue());
            
        }


    }
}
