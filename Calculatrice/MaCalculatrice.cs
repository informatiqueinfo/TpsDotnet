using System;
using System.Linq.Expressions;

namespace Calculatrice;

public class MaCalculatrice
{
    
    public decimal nb1 { get; set; }
    public decimal nb2{ get; set; }



    public MaCalculatrice(decimal nb1,decimal nb2)
    {
        this.nb1 = nb1;
        this.nb2 = nb2;
    }
    public Decimal Addition(Decimal var1, Decimal var2)
    {
        return var1 + var2;

    }

    public Decimal Soustraction(Decimal var1, Decimal var2)
    {
        return var1 - var2;

    }

    public Decimal Multiplication(Decimal var1, Decimal var2)
    {
        return var1 * var2;

    }
    public Decimal Modulo(Decimal var1, Decimal var2)
    {
        return var1 % var2;

    }

    public Decimal Division(Decimal var1, Decimal var2)
    {

        if (var2 != 0)
        {
            return var1 / var2;

        }
        else
        {

            throw new DivideByZeroException("Division par zéro interdite.");


        }

    }



}
