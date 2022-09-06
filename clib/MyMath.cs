namespace CLib;

public class MyMath
{
    public static Func<List<int>, int> Add = (List<int> nums) => nums.Sum();
    public static Func<double, double, double> Multiply = (double num1, double num2) => num1 * num2;
    public static Func<int, int, int> Subtract = (int num1, int num2) => num1 -num2 ;
    public static Func<double, double, double> Divide = (double num1, double num2) => (num1 == 0 || num2 == 0) == true ? 0 : num1/num2; 
    

}