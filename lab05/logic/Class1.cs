using System;

namespace logic
{
    public class Class1
    {


    }

    public class RationalNumber
    {
        public RationalNumber(int numerator, int denominator)
        {
           Numerator = numerator;
           Denominator = denominator;
        }
    
        public int Numerator{get; private set;}
        public int Denominator{get; private set;}
        
        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(
                Numerator.GetHashCode(),
                Denominator.GetHashCode()
            );
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class SimplifiedFraction
    {
        public SimplifiedFraction(int numerator, int denominator)
        {
           Numerator = numerator;
           Denominator = denominator;
        }
        public SimplifiedFraction(RationalNumber rationalNumber)
        {
           RationalNumber = rationalNumber;
        }

        public int Numerator{get; private set;}
        public int Denominator{get; private set;}
        public RationalNumber RationalNumber{get; private set;}
        public RationalNumber WholeUnits{get; private set;}
        public RationalNumber PartialUnits{get; private set;}
        public override int GetHashCode()
        {
            return HashCode.Combine(
                Numerator.GetHashCode(),
                Denominator.GetHashCode()
            );
        }
        public override bool Equals(object obj)
        {

        }
    }
}
