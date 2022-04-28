using System;
using System.Collections;

namespace PIApproximation.App
{
    public class CalculateDecimalsOfIrrationalNumberPI : ICalculateDecimalsOfIrrationalNumberPI
    {
        public ArrayList IterrationsAndApproximation(double epsilon)
        {
            int count = 1;
            double piOverFour = 1;
            double calculatedPi = piOverFour * 4;
            double difference = Math.Abs(calculatedPi - Math.PI);

            while(difference > epsilon)
            {
                piOverFour += Math.Pow(-1, count) / (2 * count + 1);
                count += 1;
                calculatedPi = piOverFour * 4;
                difference = Math.Abs(calculatedPi - Math.PI);
            }

            var arrayListToReturn = new ArrayList { count, Math.Round(calculatedPi,10) };

            return arrayListToReturn;
        }
    }
}
