public class CargoAirplaneBuilder : IAirplaneBuilder
{
    private Airplane _airplane = new Airplane();

    public void SetType() => _airplane.Type = "Cargo Airplane";
    public void SetSeats() => _airplane.Seats = 2;
    public void SetCargoCapacity() => _airplane.CargoCapacity = 100000;
    public void SetEngineType() => _airplane.EngineType = "Turboprop";
    public void SetWiFi() => _airplane.HasWiFi = false;
    public Airplane GetAirplane() => _airplane;
}
