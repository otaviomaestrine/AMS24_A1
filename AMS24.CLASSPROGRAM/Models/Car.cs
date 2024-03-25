class Car : Vehicles
{
    public int Speed { get; set; }

    public void On()
    {
        Speed++;
    }

    public void Brake()
    {
        Speed--;
    }
}