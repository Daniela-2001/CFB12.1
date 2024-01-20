namespace aula12._1
{
    internal class Program
    {
        static void Main(){

            int nota = 10;

            string resultado = "Reprovado";

            if(nota >= 60){
                resultado = "Aprovado";
            }

            Console.WriteLine("Resultado:{0}", resultado);
        }
    }
}