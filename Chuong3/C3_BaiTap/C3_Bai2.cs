using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_BaiTap
{
    public static class C3_Bai2
    {
        public static double EvaluatePolynomial(List<double> coefficients, double x)
        {
            double result = 0;
            int n = coefficients.Count;

            // Duyệt qua các hệ số từ hệ số cao nhất đến thấp nhất
            for (int i = n - 1; i >= 0; --i)
            {
                result = result * x + coefficients[i];
            }

            return result;
        }
    }
}
