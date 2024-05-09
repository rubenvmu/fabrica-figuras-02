public class FábricaDeFiguras
{
    public IMedible CrearFigura(TipoDeFigura tipo, int valor)
    {
        return tipo switch
        {
            TipoDeFigura.Cuadrado => new Cuadrado(valor),
            TipoDeFigura.Círculo => new Círculo(valor),
            _ => throw new ArgumentException("Tipo de figura no soportado", nameof(tipo))
        };
    }
}