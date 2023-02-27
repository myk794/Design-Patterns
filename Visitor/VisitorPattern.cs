using UnityEngine;

public class VisitorPattern : MonoBehaviour
{
   
    void Start()
    {
        Home home = new Home();
        Park park = new Park();

        Guy guy = new Guy();
        Robber robber = new Robber();
        
        home.Accept(guy);
        park.Accept(guy);
        
        home.Accept(robber);
        park.Accept(robber);
    }
}
public interface IVisitor
{
    void Visit(Home home);
    void Visit(Park park);
}
public interface IPlace
{
    void Accept(IVisitor visitor);
}
public class Park : IPlace
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
public class Home : IPlace
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Guy : IVisitor
{
    public void Visit(Home home)
    {
        Debug.Log("Guy visited the Home!");
    }

    public void Visit(Park park)
    {
       Debug.Log("Guy visited the Park");
    }
}

public class Robber : IVisitor
{
    public void Visit(Home home)
    {
        Debug.Log("Robber visited the Home!");
    }

    public void Visit(Park park)
    {
        Debug.Log("Robber visited the Park");
    }
}
