namespace TANGHALEXER1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLab1 form1 = new FrmLab1();
            form1.Show();

            FrmFileName form2 = new FrmFileName();
            form2.Show();

            FrmRegistration form3 = new FrmRegistration();
            form3.Show();

            Application.Run(form3);
        }
    }
    }
