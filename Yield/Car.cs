namespace Yield;

class Car
{
    public int ModelYear = default!;
    public string Maker = default!;

    public Car() { }

    public override string ToString()
    {
        return ModelYear.ToString() + ", " + Maker.ToString();
    }
}