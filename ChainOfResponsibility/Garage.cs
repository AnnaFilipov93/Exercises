namespace ChainOfResponsibility;

public abstract class Check
{
    protected Check? next;
    public void Setnext(Check next)
    {
        this.next = next;
    }

    public abstract void Handle(Car request);
    public int RandomNum()
    {
        Random rnd = new Random();
        return rnd.Next(1, 11);

    }
}


public class workerCheck : Check
{

    public override void Handle(Car request)
    {
        if (!request.State)
        {
            int num = RandomNum();
            System.Console.WriteLine($"{request.OwnerName} start a worker check:");
            System.Console.WriteLine($"The number: {num}");

            if (num >= 6)
            {
                Console.WriteLine($"{this.GetType().Name} fixed {request.OwnerName}'s car.");
                request.State = true;
            }
            else if (next != null)
            {
                System.Console.WriteLine($"The worker did not found the problem");
                next.Handle(request);
            }
        }
        else
        {
            Console.WriteLine($"{request.OwnerName} the car is fixed, no examination needed.");
        }

    }
}

public class MechanicCheck : Check
{

    public override void Handle(Car request)
    {
        int num = RandomNum();
        System.Console.WriteLine($"{request.OwnerName} start a mechanic check:");
        System.Console.WriteLine($"The number: {num}");

        if (num >= 6)
        {
            Console.WriteLine($"{this.GetType().Name} fixed {request.OwnerName}'s car.");
            request.State = true;
        }
        else if (next != null)
        {
            System.Console.WriteLine($"The mechanic did not found the problem");
            next.Handle(request);
        }
    }

}


public class ElectricianCheck : Check
{
    public override void Handle(Car request)
    {
        int num = RandomNum();
        System.Console.WriteLine($"{request.OwnerName} start a electrician check: ");
        System.Console.WriteLine($"The number: {num}");

        if (num >= 6)
        {
            Console.WriteLine($"{this.GetType().Name} fixed {request.OwnerName}'s car.");
            request.State = true;
        }
        else if (next != null)
        {
            System.Console.WriteLine($"The electrician did not found the problem");
            next.Handle(request);
        }


    }
}

public class DiagnosisCheck : Check
{
    public override void Handle(Car request)
    {

        int num = RandomNum();
        System.Console.WriteLine($"{request.OwnerName} start an expert check: ");
        System.Console.WriteLine($"The number: {num}");

        if (num >= 6)
        {
            Console.WriteLine($"{this.GetType().Name} fixed {request.OwnerName}'s car.");
            request.State = true;
        }
        else
        {
            System.Console.WriteLine($"The expert did not found the problem");

        }


    }
}
