using System;
using System.Text.RegularExpressions;

public static class Utilidades
{
    public static bool EsCorreoValido(string email)
    {
        // Llama al método auxiliar para verificar si está en blanco
        if (EstaEnBlanco(email))
        {
            return false;
        }

        string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, patron);
    }

    public static bool EstaEnBlanco(string texto)
    {
        return string.IsNullOrWhiteSpace(texto);
    }
} //fin de la clase Utilidades