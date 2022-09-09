namespace Encontro_remoto_2.Classes
{
    public static class Utils
    {
        
        public static void BarraCarregamento(string texto, int repeticao, string elemento, int tempo){
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"{texto}");

            for (var contador = 0; contador < repeticao; contador++)
            {
                Thread.Sleep(500);
                Console.Write($"{elemento}");
            }
            Console.ResetColor();
        }

    }
}