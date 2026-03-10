namespace VikingNS;

public class Viking : IView
{
    public string Name { get; set; }
    public Global.Status Status { get; set; }
    public int Health { get; set; }
    public Global.Weapon Weapon { get; set; }
    public bool Shield { get; set; }

    public Viking(
    
        string name = "Bjorn",
        Global.Status status = Global.Status.KARL,
        int health = 150,
        Global.Weapon weapon = Global.Weapon.AXE,
        bool shield = false)
    {
        Name = name;
        Status = status;
        Health = health;
        Weapon = weapon;
        Shield = shield;
    }
    

    public Viking(Viking other)
    {
        Name = other.Name;
        Status = other.Status;
        Health = other.Health;
        Weapon = other.Weapon;
        Shield = other.Shield;
    }

    public void ViewH()
    {
        Console.WriteLine("Name Status Health Weapon Shield");
        Console.WriteLine($"{Name} {FormatStatus(Status)} {Health} {FormatWeapon(Weapon)} {Shield}");
    }

    public void ViewV()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Status: {FormatStatus(Status)}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Weapon: {FormatWeapon(Weapon)}");
        Console.WriteLine($"Shield: {Shield}");
    }

    private static string FormatStatus(Global.Status status)
    {
        return status switch
        {
        Global.Status.JARL => "Jarl",
        Global.Status.KARL => "Karl",
        Global.Status.THRALL => "Thrawl",
        _=> status.ToString()
        };
    }

    private static string FormatWeapon(Global.Weapon weapon)
    {
        return weapon switch
        {
            Global.Weapon.AXE => "Axe",
            Global.Weapon.SWORD => "Sword",
            _=> weapon.ToString()
        };
    }
}