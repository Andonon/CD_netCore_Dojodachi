public class Dachi
{
    public string dachiname {get; set;}
    public int happiness {get; set;}
    public int fullness {get; set;}
    public int energy {get; set;}
    public int meals {get; set;}

    public Dachi(string name)
    {
        dachiname = name;
        happiness = 20;
        fullness = 20; 
        energy = 50; 
        meals = 3;
    }

}