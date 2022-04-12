
namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Check c1 = new workerCheck();
            Check c2 = new MechanicCheck();
            Check c3 = new ElectricianCheck();
            Check c4 = new DiagnosisCheck();
            c1.Setnext(c2);
            c2.Setnext(c3);
            c3.Setnext(c4);

            List<Car> cars = new List<Car>();
            cars.Add(new Car("Anna", true));
            cars.Add(new Car("Tommy", false));
            cars.Add(new Car("Vadim", false));


            foreach (Car car in cars)
            {
                c1.Handle(car);
            }

        }
    }


}
