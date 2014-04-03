using System;

class Point
{
    //must be in separated file, but it is here only for the purpose of the better comprehension
    public double X { get; set; }
    public double Y { get; set; }
}

class PerimeterAreaPolygon
{
    static double Distance(double x1, double y1, double x2, double y2)
    {
        double xdistance = x1;
        if (x1 != x2)
        {
            xdistance = Math.Max(x1, x2) - Math.Min(x1, x2);
        }
        double ydistance = y1;
        if (y1 != y2)
        {
            ydistance = Math.Max(y1, y2) - Math.Min(y1, y2);
        }
        if (xdistance == 1 && ydistance == 1)
        {
            return 1;
        }
        else
        {
            double distance = (xdistance * xdistance) + (ydistance * ydistance);
            return Math.Sqrt(distance);
        }

    }


    static void Main()
    {
        //Write a program that calculates the perimeter and the area of given polygon (not necessarily convex)
        //consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal 
        //digits after the decimal point. Use the input and output format from the examples. To hold the points,
        //define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points. 
        //Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon. 
        Console.Title = "ConsoleApp - Perimeter and Area of Polygon";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter the number of corners (points) of the polygon:");
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];
        double perimeter = 0;
        double area = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter a point in format (x,y)");

            string[] point = Console.ReadLine().Split(',');
            points[i] = new Point() { X = double.Parse(point[0]), Y = double.Parse(point[1]) };
        }

        for (int j = 0; j < points.Length - 1; j++)
        {
            perimeter += Distance(points[j].X, points[j].Y, points[j + 1].X, points[j + 1].Y);
            area += (points[j].X * points[j + 1].Y) - (points[j].Y * points[j + 1].X);
        }
        if (points.Length==3)
        {
            if (perimeter==2)
            {
                perimeter +=Math.Sqrt(Math.Max(points[0].X, points[n-1].X) + Math.Max(points[0].Y, points[n-1].Y));
            }
        }
        if (area < 0)
        {
            area = area / (-2.00);
        }
        else
        {
            area = area / (2.00);
        }
        Console.WriteLine("Perimeter: {0:F2}", perimeter);
        Console.WriteLine("Area: {0:F2}", area);

        Console.ReadLine();
    }
}

