namespace CasoJuegoCraps;

public class Craps
{
    // crea el generador de números aleatorios para usarlo en el método
    private Random numerosAleatorios = new Random();

    // enumeración con constantes que representan el estado del juego
    private enum NombreDados
    {
        DOS_UNO = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12
    }

    private enum Estado
    {
        CONTINUA,
        GANA,
        PIERDE
    }

    // ejecuta el juego de Craps
    public void Jugar()
    {
        // estado del juego puede contener CONTINUA, GANA o PIERDE
        Estado estadoJuego = Estado.CONTINUA;

        int miPunto = 0; // punto si no se gana o pierde en el primer lanzamiento
        int sumaDeDados = LanzarDados(); // primer lanzamiento de los dados

        // determina el estado del juego y con base al primer tiro
        // conversión explícita (o casting)
        switch ((NombreDados)sumaDeDados)
        {
            case NombreDados.SIETE:
            case NombreDados.ONCE:
                estadoJuego = Estado.GANA;
                break;

            case NombreDados.DOS_UNO:
            case NombreDados.TRES:
            case NombreDados.DOCE:
                estadoJuego = Estado.PIERDE;
                break;

            default: // no ganó ni perdió, por lo que recuerda el punto
                estadoJuego = Estado.CONTINUA; // el juego no ha terminado
                miPunto = sumaDeDados; // recuerda el punto
                Console.WriteLine($"El punto es {miPunto}");
                break;
        } // fin del switch

        // mientras el juego no termine
        while (estadoJuego == Estado.CONTINUA) // mientras el juego no termine
        {
            sumaDeDados = LanzarDados(); // lanzamiento de los dados otra vez

            // determina el estado del juego
            if (sumaDeDados == miPunto) // gana por hacer su punto
                estadoJuego = Estado.GANA;
            else
                if (sumaDeDados == (int)NombreDados.SIETE) // pierde al tirar 7 antes de hacer su punto
                    estadoJuego = Estado.PIERDE;
        } // fin del while

        // muestra mensaje de que ganó o perdió
        if (estadoJuego == Estado.GANA)
            Console.WriteLine("El jugador gana");
        else
            Console.WriteLine("El jugador pierde");

    } // fin del método Jugar

    public int LanzarDados()
    {
        // elige valores aleatorios para los dados
        int dado1 = numerosAleatorios.Next(1, 7); // primer dado
        int dado2 = numerosAleatorios.Next(1, 7); // segundo dado

        int suma = dado1 + dado2; // suma de los dados

        // muestra los resultados de este lanzamiento
        Console.WriteLine($"El jugador lanzó {dado1} + {dado2} = {suma}");

        return suma; // devuelve la suma de los dados
    } // fin del método LanzarDados
}
