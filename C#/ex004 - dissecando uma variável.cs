NÂO FUNCIONAL

// Faça um programa que leia algo pelo teclado e mostre na tela o seu tipo primitivo e todas as informações possíveis sobre ele

using System;

static class IO {
    public static string input(string text) {
        Console.Write(text);
        return Console.ReadLine();
    }
    
    public static void print(string text, string end="\n") {
        Console.Write($"{text}{end}");
    }
}

static class TestString {
    public static bool isSpace(string text) {
        bool nullOrEmpty = String.isNullOrEmpty(text);
        bool nullOrWhiteSpace = String.IsNullOrWhiteSpace(text);
        
        // IO.print((!nullOrEmpty && nullOrWhiteSpace));
    }
}

class Program {
    public static void Main() {
        string text = IO.input("Digite algo: ");
        
        IO.print(
            $"O tipo primitivo é {text.GetType()}"    
        );
        
        TestString.isSpace(text);
        
    }
}
