using System.Collections;
namespace Yield;
class Agency 
{
    public Car[] Cars = default!;
    public Agency() { }

    public IEnumerator<Car> GetEnumerator()
    {
        foreach (var car in Cars)
            yield return car;
    }
    public IEnumerable<Car> GetCars(int item)
    {
        Car[] filtered = Cars.Where(c => c.ModelYear.CompareTo(item) == 0).ToArray();

        foreach (var car in filtered)
            yield return car;
    }
    public IEnumerable GetCars(string item)
    {
        Car[] filtered = Cars.Where(c => c.Maker.CompareTo(item) == 0).ToArray();

        foreach (var car in filtered)
            yield return car;
    }

}