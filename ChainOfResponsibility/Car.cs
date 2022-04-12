namespace ChainOfResponsibility;

public class Car{
    public string OwnerName;
    public bool State; // true = fixed  false = not fixed
    public string? DepartmentFoundTheFault;

    public Car(string name, bool state = false){

        OwnerName = name;
        State = state;

    }

}