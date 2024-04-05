namespace ASSIGNMENTS
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
           //Application.Run(new Form());   //Addition of two numbers
            //Application.Run(new Form2());  //Calculate Area and Perimeter
           //Application.Run(new Form3());   //Calculate T Shirt
           //Application.Run(new Form4());   //Validation Log in Form
            Application.Run(new Form5());    //Railway Reservation
           //Application.Run(new Form6());   //OPD Registration
           //Application.Run(new Form7());   //Calculator


        }
    }
}