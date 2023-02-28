using UnityEngine;

public class Decorator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ICar myCar = new MyCar();
        Debug.Log(myCar.GetCarProperties());
        ICar engineDecorator = new EngineDecorator(myCar);
        myCar = engineDecorator;
        Debug.Log(myCar.GetCarProperties());
        ICar colorDecorator = new ColorDecorator(myCar);
        myCar = colorDecorator;
        Debug.Log(myCar.GetCarProperties());
    }
}
#region Base interface
public interface ICar
{
    string GetCarProperties();
}
#endregion

#region Concrete implementation
public class MyCar : ICar
{
    public string GetCarProperties()
    {
        return "Nissan Skyline R34";
    }
}
#endregion

#region Base decorator
public class CarDecorator : ICar
{
    private ICar _car;

    public CarDecorator(ICar car)
    {
        _car = car;
    }
    public virtual string GetCarProperties()
    {
        return _car.GetCarProperties();
    }
}
#endregion

#region Concrete decorators

public class EngineDecorator : CarDecorator
{
    public EngineDecorator(ICar car) : base(car) { }

    public override string GetCarProperties()
    {
        string props = base.GetCarProperties();
        props += "   with RB26 2.6L Engine";
        return props;
    }
}

public class ColorDecorator : CarDecorator
{
    public ColorDecorator(ICar car) : base(car) { }

    public override string GetCarProperties()
    {
        string props = base.GetCarProperties();
        props += "   Color: Midnight Purple";
        return props;
    }
}

#endregion


