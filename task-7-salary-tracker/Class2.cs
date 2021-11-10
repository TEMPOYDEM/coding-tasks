using System;

public class Seller
{
	public Seller()
	{
		double Salary = 40
	}
}
public class Main_Seller
{
	public Main_Seller()
	{
		double Salary = (Seller.Salary)* (Seller.Salary)*0.15*(Math.Pow(10,4))+Month_Income*0.1*Math.Pow(10,-2)
	}
}
public class Manager
{
	public Manager()
	{
		double Salary = (Seller.Salary) * (Seller.Salary) * 0.25 * (Math.Pow(10, 4)) + Month_Income * 0.5 * Math.Pow(10, -2)
	}
}
public class Driver
{
	public Driver()
	{
		double Salary = Seller.Salary
	}
}
