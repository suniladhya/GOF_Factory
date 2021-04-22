using System;


public abstract class Plan
{
    public double rate;
    public abstract void getRate();

    public void calculateBill(int unit)
    {
        Console.WriteLine(unit * rate);
    }
}
