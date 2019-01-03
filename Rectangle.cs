using System;
					
public class Rectangle
{
	private int lengthOfRectangle;
	private int breadthOfRectangle;
	public Rectangle(int lengthOfRectangle, int breadthOfRectangle) 
	{ 	
		this.lengthOfRectangle = lengthOfRectangle;
		this.breadthOfRectangle = breadthOfRectangle;
	}
	public Rectangle() 
	{ 	
		this.lengthOfRectangle = 0;
		this.breadthOfRectangle = 0;
	}
	public int Perimeter()
	{
		return this.lengthOfRectangle+this.breadthOfRectangle;	
	}
	public int Area()
	{
		return this.lengthOfRectangle*this.breadthOfRectangle;	
	}
	
}