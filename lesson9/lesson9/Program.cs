internal class Program
{
    private static void Main(string[] args)
    {
        Shape[] shapes = new Shape[4];


        shapes[0] = new Rectangle(5, 6);
        shapes[1] = new Circle(5);
        shapes[2] = new Rectangle(15, 20);
        shapes[3] = new Circle(50.2);

        foreach (var item in shapes)
        {
            Console.WriteLine("The area of the shape is: " + item.Area());
            Console.WriteLine("The perimeter of the shape is: " + item.Perimeter());
            Console.WriteLine();
        }

    }
}
public class Rectangle:Shape
{
    protected double side1 {  get; set; }
    protected double side2 { get; set; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public override double Area()
    {
        return side1 * side2;
    }

    public override double Perimeter()
    {
        return 2 * side1 * side2;
    }
}
public class Shape:Location
{
   
    public virtual double Area()
    {
        return 0.000;
    }
    public virtual double Perimeter()
    {
        return 0.000;
    }
}
public class Circle:Shape
{
    protected double radius { get; set; }

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return 3.14 * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * 3.14 * radius;
    }
}
public class Location
{
    private double x { get; set; }
    private double y { get; set; }
}