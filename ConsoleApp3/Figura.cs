public interface IMedible
{
    double ObtenerÁreaDeSuperficie();
    double ObtenerPerímetro();
}

public class Cuadrado : IMedible
{
    private readonly int lado;

    public Cuadrado(int lado)
    {
        if (lado <= 0)
        {
            throw new ArgumentException("La longitud del lado debe ser positiva", nameof(lado));
        }
        this.lado = lado;
    }

    public double ObtenerÁreaDeSuperficie() => lado * lado;
    public double ObtenerPerímetro() => 4 * lado;

    public override string ToString() => $"Lado de la figura: {lado}";
}

public class Círculo : IMedible
{
    private readonly int radio;

    public Círculo(int radio)
    {
        if (radio <= 0)
        {
            throw new ArgumentException("El radio debe ser positivo", nameof(radio));
        }
        this.radio = radio;
    }

    public double ObtenerÁreaDeSuperficie() => Math.PI * radio * radio;
    public double ObtenerPerímetro() => 2 * Math.PI * radio;

    public override string ToString() => $"Radio de la figura: {radio}";
}

/*
Interfaz IMedible
La interfaz IMedible define dos métodos que deben ser implementados por las clases que la utilicen: ObtenerÁreaDeSuperficie() y ObtenerPerímetro().
Clase Cuadrado : IMedible
La clase Cuadrado implementa la interfaz IMedible, lo que significa que debe proporcionar una implementación para los métodos definidos en la interfaz.
Tiene un campo privado llamado lado que representa la longitud de un lado del cuadrado.
El constructor de Cuadrado recibe la longitud del lado como parámetro y verifica que sea un valor positivo. En caso contrario, lanza una excepción ArgumentException.
Implementa el método ObtenerÁreaDeSuperficie() que calcula el área del cuadrado como el cuadrado del lado.
Implementa el método ObtenerPerímetro() que calcula el perímetro del cuadrado como 4 veces el lado.
Sobrescribe el método ToString() para devolver una representación legible del cuadrado con su lado.
Clase Círculo : IMedible
La clase Círculo también implementa la interfaz IMedible.
Tiene un campo privado llamado radio que representa el radio del círculo.
El constructor de Círculo recibe el radio como parámetro y verifica que sea un valor positivo. En caso contrario, lanza una excepción ArgumentException.
Implementa el método ObtenerÁreaDeSuperficie() que calcula el área del círculo como π * radio^2.
Implementa el método ObtenerPerímetro() que calcula el perímetro del círculo como 2 * π * radio.
Sobrescribe el método ToString() para devolver una representación legible del círculo con su radio*/