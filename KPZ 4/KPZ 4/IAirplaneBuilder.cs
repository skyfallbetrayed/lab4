public interface IAirplaneBuilder
{
    void SetType();
    void SetSeats();
    void SetCargoCapacity();
    void SetEngineType();
    void SetWiFi();
    Airplane GetAirplane();
}
