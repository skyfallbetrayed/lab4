public class Airplane
{
    public string Type { get; set; }
    public int Seats { get; set; }
    public int CargoCapacity { get; set; }
    public string EngineType { get; set; }
    public bool HasWiFi { get; set; }

    public override string ToString()
    {
        return $"Type: {Type}\nSeats: {Seats}\nCargo Capacity: {CargoCapacity} kg\nEngine: {EngineType}\nWiFi: {(HasWiFi ? "Yes" : "No")}";
    }
}