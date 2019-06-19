public delegate void DelegadoSueldo(Entidades.Empleado e, float f);
public delegate void DelSueldo(Entidades.EmpleadoMejorado e, Entidades.EmpleadoSueldoArgs ea);

public enum TipoManejador
{
    LimiteSueldo,
    Log,
    Ambos
}
    