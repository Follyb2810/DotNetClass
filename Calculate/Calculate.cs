namespace MyMathOperation{
    public class Calculate{
        public static double Add(double num1,double num2){
            return num1 + num1;
        }
            public static double Subtract(double num1,double num2){
            return num1 - num1;
        }
            public static double Divide(double num1,double num2){
            if(num2 != 0){
                return num1 / num1;
            }else{
                throw new DivideByZeroException("cant dive by zero");
            };
        }
            public static double Multiply(double num1,double num2){
            return num1 * num1;
        }
            public static double SquareRoot(double num1){
            return Math.Sqrt(num1);
        }
    }
}