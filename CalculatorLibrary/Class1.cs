namespace CalculatorLibrary
{
    public class Calculator : ISimpleCalculator
    {
        public int AddNos(int fno, int sno)
        {
           return fno + sno;    
        }

        public int DivideNos(int fno, int sno)
        {
            return fno/ sno;
        }

        public int MultiplyNos(int fno, int sno)
        {
            return fno* sno;
        }

        public int SubtractNos(int fno, int sno)
        {
            return (fno - sno);
        }
    }


    public class ScientificCalculator : Calculator, IScientificCalculator
    {
        public double Cos(double v)
        {
         double cosValue= Math.Cos(v);
            return  cosValue;   
        }

        public double Sin(double v)
        {
          double sinValue=Math.Sin(v);  
            return sinValue;
        }

        public double Tan(double v)
        {
            return Math.Tan(v);
        }
    }



    public class SpecialCalci : IScientificCalculator, ISpecial
    {
        public double Cos(double v)
        {
            //throw new NotImplementedException();
            return Math.Cos(v);
        }

        public double Sin(double v)
        {
            //throw new NotImplementedException();
            return Math.Sin(v);
        }



        public double Square(double fno)
        {
            // throw new NotImplementedException();
            return fno * fno;
        }

        public double SquareRoot(double v)
        {
            return Math.Sqrt(v);
        }

        public double Tan(double v)
        {
            return Math.Tan(v);
        }
    }



    public interface ISimpleCalculator
    {
        public int AddNos(int fno, int sno);
        public int SubtractNos(int fno, int sno);
        public int MultiplyNos(int fno, int sno);
        public int DivideNos(int fno, int sno);

    
    }

    public interface IScientificCalculator
    {

        public double Sin(double v);
        public double Cos(double v);
        public double Tan(double v);


    }

    public interface ISpecial
    { 
    public double SquareRoot(double v);
    public double Square(double fno);
          
    
    }


}
