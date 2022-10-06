// See https://aka.ms/new-console-template for more information
using Credit_Score_App;

//Implicit type Variable : for local variables when the type of the variable is obvious from right side of assignment, or when the precise type is not important.
var implicitType = "Just assigning string to var";

//This is Manual Testing

//Arrange
PointCalculator pointCalculator = new PointCalculator();
CreditCalculator creditCalculator = new CreditCalculator(pointCalculator);

Customer customer_decline = new Customer(0, 0, 3, 52);              
                                        // 0    0   4   6   =   10  ($0)
Customer customer_fail =    new Customer(451, 3, 0, 20);            
                                        // 1    -6  0   3   =   -2  ($0)
Customer customer_pass1 =   new Customer(999, 0, 3, 40);            
                                        // 3    0   4   5   =   12  ($600)
Customer customer_pass2 =   new Customer(451, 2, 0, 20); 
                                        // 1    -3  0   3   =   1   ($100)
Customer customer_john =    new Customer(750, 1, 4, 29);    
                                        // 2    -1  4   4   =   9   ($600)
//Act
Console.Write("Customer 1 : ");
Console.Write(pointCalculator.Calculate(customer_decline) + " points, ");
Console.WriteLine(creditCalculator.CalculateCredit(customer_decline));
Console.Write("Customer 2 : ");
Console.Write(pointCalculator.Calculate(customer_fail) + " points, ");
Console.WriteLine(creditCalculator.CalculateCredit(customer_fail));
Console.Write("Customer 3 : ");
Console.Write(pointCalculator.Calculate(customer_pass1) + " points, ");
Console.WriteLine(creditCalculator.CalculateCredit(customer_pass1));
Console.Write("Customer 4 : ");
Console.Write(pointCalculator.Calculate(customer_pass2) + " points, ");
Console.WriteLine(creditCalculator.CalculateCredit(customer_pass2));
Console.Write("Customer 5 : ");
Console.Write(pointCalculator.Calculate(customer_john) + " points, ");
Console.WriteLine(creditCalculator.CalculateCredit(customer_john));

/* 
 * First Data Point :  * BureauScore
 * 0-450    Decline
 * 451-700  1
 * 701-850  2
 * 851-1000 3
 * 
 * Second Data Point : * MissedPayment
 * 0    0
 * 1    -1  
 * 2    -3
 * 3    -6
 * 
 * Third Data Point : * CompletedPayment
 * 0    0
 * 1    2
 * 2    3
 * 3    4
 * 
 * Maximum Point : * Age
 * 18-25    3
 * 26-35    4
 * 36-50    5
 * 51+      6
 * 
 * This means the input would be
 * bureauPoint, missedPayment, completedPayment, age
 * 
 * Credit
 * 0    0
 * 1    100 
 * 2    200
 * 3    300
 * 4    400
 * 5    500
 * 6    600
 */