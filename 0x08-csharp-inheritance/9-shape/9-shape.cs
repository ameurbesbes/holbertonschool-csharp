using System;
/// <summary>
/// Base class for shapes. 
/// </summary>
class Shape
{
    /// <summary>
    /// Not Implemented yet
    /// </summary>
    /// <returns>An integer</returns>
    public virtual int Area() => throw new NotImplementedException("Area() is not implemented");
}
/// <summary>
/// Rectangle: Class that inherits from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// width setter and getter
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
    /// <summary>
    /// returns the area of the rectangle
    /// </summary>
    /// <returns></returns>
    public new int Area()
    {
        return (width * height);
    }
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}
class Square : Rectangle
{
    private int size;
    /// <summary>
    /// Getter and setter for size value
    /// </summary>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
                base.Height = value;
            base.Width = value;
            this.size = value;
        }
    }
    /// <summary>
    /// [Square] size / size
    /// </summary>
    public override string ToString()
    {
        return String.Format("[Square] {0} / {0}", this.size);
    }
}