//Create a named tuple
var pt = (X: 1, Y: 2);

//Access tuple elements
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

//Modify tuple elements
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

//Modify first tuple using 'with' expression to create a new tuple
var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}.");

//Tuple types
var subscript = (A: 0, B: 0);
subscript = pt; //Since both tuples share types, this assignment is valid
Console.WriteLine(subscript);

//Testing Tuples
//var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
//var person = (FirstName: "", LastName: "");
//var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

//Using Records
Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");

//Using Record method
double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");

//Testing Records
public record Point(int X, int Y)

{
    public double Slope() => (double)Y / (double)X;
}