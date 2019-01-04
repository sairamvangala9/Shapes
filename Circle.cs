public class Circle
{
	private double radius;
	public Circle(double radius)
	{
		this.radius=radius;
	}
	public Circle()
	{
		this.radius=0;
	}
	public double AreaOfCircle()
	{
		return Math.PI*radius*radius;
	}
	public double PerimeterOfCircle()
	{
		return 2*Math.PI*radius;
	}
//update from sairam push test
}
