public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price) { }

    public void EnableCamera() => Console.WriteLine("Camera enabled");

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone - Brand: {Brand}, Price: {Price}");
    }
}
