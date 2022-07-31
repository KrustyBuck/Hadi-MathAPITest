namespace Hadi_MathAPI.Model
{
    public class MathOperator
    {
        public static double Add(MathValue mVal)
        {
            return mVal.Value1 + mVal.Value2;
        }

        public static double Substract(MathValue mVal)
        {
            return mVal.Value1 - mVal.Value2;
        }

        public static double Multiply(MathValue mVal)
        {
            return mVal.Value1 * mVal.Value2;
        }

        public static double Divide(MathValue mVal)
        {
            //throw error message when Value1 or Value2 is 0
            if (mVal.Value1 == 0 || mVal.Value2 == 0)
                throw new ArgumentException("Value must be greater than 0.");

            return mVal.Value1 / mVal.Value2;
        }
    }
}
