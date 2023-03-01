namespace PW5 {
    internal class Program {
        private static void Main(string[] args) { }
    }

    public static class Operations {
        public static double Addition(object first, object second) {
            double augend, addend, sum;

            try {
                augend = ToDouble(first);
                addend = ToDouble(second);
                sum = augend + addend;
                if (double.IsInfinity(sum)) {
                    return double.NaN;
                }
            }
            catch {
                sum = double.NaN;
            }

            return sum;
        }

        public static double Subtraction(object first, object second) {
            double minuend, subtrahend, difference;

            try {
                minuend = ToDouble(first);
                subtrahend = ToDouble(second);
                difference = minuend - subtrahend;
                if (double.IsInfinity(difference)) {
                    return double.NaN;
                }
            }
            catch {
                difference = double.NaN;
            }

            return difference;
        }

        public static double Multiplication(object first, object second) {
            double multiplier, multiplicand, product;

            try {
                multiplier = ToDouble(first);
                multiplicand = ToDouble(second);
                product = multiplier * multiplicand;
                if (double.IsInfinity(product)) {
                    return double.NaN;
                }
            }
            catch {
                product = double.NaN;
            }

            return product;
        }

        public static double Division(object first, object second) {
            double dividend, divisor, fraction;

            try {
                dividend = ToDouble(first);
                divisor = ToDouble(second);
                fraction = dividend / divisor;
                if (double.IsInfinity(fraction)) {
                    return double.NaN;
                }
            }
            catch {
                fraction = double.NaN;
            }

            return fraction;
        }

        public static double Exponentiation(object first, object second) {
            int exponent;
            double @base, power = 1;

            try {
                @base = ToDouble(first);
                exponent = ToInt32(second);
                if (exponent > 0) {
                    for (int i = 0; i < exponent; i++) {
                        power *= @base;
                    }
                }
                else if (exponent < 0) {
                    for (int i = exponent; i > 0; i--) {
                        power /= @base;
                    }
                }

                if (double.IsInfinity(power)) {
                    return double.NaN;
                }
            }
            catch {
                power = double.NaN;
            }

            return power;
        }
    }
}