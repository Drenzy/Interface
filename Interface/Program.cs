public class Progam
{
    Car car = new Car(); 
         Banana banana = new Banana();
         Person person = new Person();
    public void Main(string[] args)
    {
        insert();
    }

    public void insert()
    {

        List<string> list = new List<string>()
        {
           list.Add(car.SigNavn)
        };
    }
}

public class Car
{
    
    public string SigNavn(string CarName ="Volvo")
    {
        return CarName;
    }
}

public class Banana
{
    public string SigNavn(string BananaName = "BananManden")
    {
        return BananaName;
    }
}

public class Person
{
  public void SigNavn(string PersonName = "Palle")
    {
       Console.WriteLine(PersonName);
    }

}