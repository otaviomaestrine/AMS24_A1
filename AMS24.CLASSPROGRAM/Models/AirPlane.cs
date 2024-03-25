class AirPlane : Vehicles
{
    public int Latitude { get; set; }

    public void Up()
    {
        Latitude++;
    }

    public void Down()
    {
        Latitude--;
    }

}