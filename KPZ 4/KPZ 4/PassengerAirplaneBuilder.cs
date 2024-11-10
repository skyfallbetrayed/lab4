public class PassengerAirplaneBuilder : IAirplaneBuilder
{
    private Airplane _airplane = new Airplane();

    public void SetType() => _airplane.Type = "Passenger Airplane";
    public void SetSeats() => _airplane.Seats = 180;
    public void SetCargoCapacity() => _airplane.CargoCapacity = 20000;
    public void SetEngineType() => _airplane.EngineType = "Turbofan";
    public void SetWiFi() => _airplane.HasWiFi = true;
    public Airplane GetAirplane() => _airplane;
}
