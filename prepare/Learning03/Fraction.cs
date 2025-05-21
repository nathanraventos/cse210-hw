
using System.Runtime.CompilerServices;

///<summary>
/// Represents a fraction with a numerator and denominator.
/// This is more accurate than storing numbers in a double.
/// </summary>
public class Fraction
{
    private int _numer;
    private int _denom;

    public Fraction()
    {
        _numer = 1;
        _denom = 1;
    }
    public Fraction(int whole)
    {
        _numer = whole;
        _denom = 1;
    }
    public Fraction(int numer, int denom)
    {
        _numer = numer;
        _denom = denom;
    }

    public string GetFractionString()
    {
        string representation = $"{_numer} / {_denom}";
        return representation;
    }

    public double GetDecimalValue()
    {
        double value = (double)_numer / (double)_denom;
        return value;
    }
    public void SetFractionNumer(int numer)
    {
        _numer = numer;
    }
    public void SetFractionDenom(int denom)
    {
        _denom = denom;
    }

}