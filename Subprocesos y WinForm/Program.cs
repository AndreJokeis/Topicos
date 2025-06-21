namespace Subprocesos_y_WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Form1 - Ejemplo
            //Application.Run(new Form1());
            //Form Invoke - Ejemplo
            //Application.Run(new InvokeForm());
            //Form BackGround - Ejemplo
            //Application.Run(new BackgroundWorkerForm());
            //Form BackGround - Ejercicio 1
            //Application.Run(new BackgroundClase.BackgroundWorkerF());
            //Form Fibonacci - Ejercicio 1
            //Application.Run(new FibonacciCalculator.Fibonacci());
            //Form Fibonacci - Ejercicio 1
            Application.Run(new Player.LoadPlayer());
        }
    }
}