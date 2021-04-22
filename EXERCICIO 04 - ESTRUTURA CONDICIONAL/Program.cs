using System;
class Program{
    /// -------> START / MAIN 
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Main(string[] args){
        Msg();
        Conditional();
    }
    /// -------> FUNCTIONS
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Msg(){
        Console.WriteLine("Dizer se o programa deve mostrar uma mensagem são Multiplos ou não sao multiplos");
    }
    //------------------------------------------------------------------------------------------//
    static void Conditional(){
        int h1, h2, duracao;

        Console.Write("HORARIO INICIO DO JOGO: ");
        h1 = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("HORARIO FIM DO JOGO: ");
        h2 = int.Parse(Console.ReadLine());
          
        if (h1 < h2) {
            duracao = h2 - h1;
        }
        else {
            duracao = 24 - h1 + h2;
        }
        Console.Write("O JOGO DUROU " +duracao+ " HORAS");                
    }
    /////////////////////////////////////////////////////////////////////////////////////////////
    /// -------> END
}
