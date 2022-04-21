public interface DietBase
{
    string Menu();
}


class VeganDiet : DietBase
{
    public string Menu()
    {
        return "brown rice,pea protein powder, brown rice protein, hemp protein,\nalmond, cashew, coconut, flax, oat, rice, and soy milks";
    }
}

class VegetarianDiet : DietBase
{
    public string Menu()
    {
        return "Eggs,Fruits,Vegetables";
    }
}
class JuiceDiet : DietBase
{
    public string Menu()
    {
        return "Strawberry-Cucumber Juice, Green Juice, Tomato-Vegetable Juice";
    }
}

abstract class DietFactory
{

    public abstract DietBase FactoryMethod();


    public string SomeMenu()
    {
        
        var product = FactoryMethod();
        var result ="The diet you chose is:"+product+"\nThe menu is:\n"
            + product.Menu();

        return result;
    }
}

class VeganDietFactory : DietFactory
{

    public override DietBase FactoryMethod()
    {
        return new VeganDiet();
    }
}

class VegetarianDietFactory : DietFactory
{
    public override DietBase FactoryMethod()
    {
        return new VegetarianDiet();
    }
}
class JuiceDietFactory : DietFactory
{
    public override DietBase FactoryMethod()
    {
        return new JuiceDiet();
    }
}