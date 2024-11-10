using System;
using System.Collections.Generic;

public class AirplaneDirector
{
    private readonly IAirplaneBuilder _builder;
    private readonly Queue<Action> _steps;

    public AirplaneDirector(IAirplaneBuilder builder)
    {
        _builder = builder;
        _steps = new Queue<Action>(new Action[]
        {
            _builder.SetType,
            _builder.SetSeats,
            _builder.SetCargoCapacity,
            _builder.SetEngineType,
            _builder.SetWiFi
        });
    }

    public bool PerformNextStep()
    {
        if (_steps.Count > 0)
        {
            _steps.Dequeue().Invoke();
            return true;
        }
        return false;
    }

    public Airplane GetAirplane() => _builder.GetAirplane();

    public string GetCurrentState() => GetAirplane().ToString();
}
