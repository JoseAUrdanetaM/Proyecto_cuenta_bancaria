namespace Proyecto_cuenta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double saldo = 0;
            bool logIn = true;

            Console.WriteLine("════════ Sistema bancario ═════════");

            while (logIn)
            {
                Console.WriteLine("");
                Console.WriteLine("╔═══  Seleccione una opción: ═════╗");
                Console.WriteLine("║     1. Depositar dinero         ║");
                Console.WriteLine("║     2. Retirar dinero           ║");
                Console.WriteLine("║     3. Ver saldo                ║");
                Console.WriteLine("║     4. Salir                    ║");
                Console.WriteLine("╚═════════════════════════════════╝");
                Console.WriteLine("");
                Console.Write("Opción:");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el monto a depositar: ");
                        string entradaDeposito = Console.ReadLine();
                        double deposito;

                        //TryParse ( Ingresa String(entradaDeposito) - > Pasa a Double(deposito)
                        if (double.TryParse(entradaDeposito, out deposito) && deposito > 0)
                        {
                            saldo += deposito;
                            Console.WriteLine($"Se depositaron S/{deposito}. \nSaldo actual: S/{saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese el monto a retirar: ");
                        string entradaRetiro = Console.ReadLine();
                        double retiro;

                        if (double.TryParse(entradaRetiro, out retiro) && retiro > 0)
                        {
                            if (retiro <= saldo)
                            {
                                saldo -= retiro;
                                Console.WriteLine($"Se retiraron S/{retiro}. Saldo actual: S/{saldo}");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido.");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Saldo actual: S/{saldo}");
                        break;

                    case "4":
                        Console.WriteLine("Cerrando sesión. \nGracias por usar el sistema bancario.");
                        Console.WriteLine("Presione una tecla para salir...");
                        Console.ReadKey(); 
                        logIn = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }

        }
    }
}
