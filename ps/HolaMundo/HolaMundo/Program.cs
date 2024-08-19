namespace saludo
{
    internal class Program
    {
        static void main(string[] args)
        {
            //leer el nombre y saludar 
            string nombre;
            string apellido;
            Console.Write("dime tu nombre");
            nombre = Console.ReadLine();
            Console.Write("hola +{nombre} {apellido}, mucho gusto");
        }
    }
}