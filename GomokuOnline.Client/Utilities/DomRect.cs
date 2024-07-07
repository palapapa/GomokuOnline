namespace GomokuOnline.Client.Utilities;

/// <summary>
/// A class used to access the return value of the <c>Element.getBoundingClientRect</c> JS function.
/// </summary>
class DomRect
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Top { get; set; }
    public double Right { get; set; }
    public double Bottom { get; set; }
    public double Left { get; set; }
}
