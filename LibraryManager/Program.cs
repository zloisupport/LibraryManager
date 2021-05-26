using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
   

         [STAThread]
     
        static void Main()
        {
            AppDbContext db;
        
            db = new AppDbContext();
            if (!db.Database.Exists())
            {
                MessageBox.Show("Нет соединения с SQl Server\n Проверьте конфигурацию программы\n Экстренное завершение работы программы", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Auth());
          
            //  Application.Run(new form.MainMenu());

        }

    }
}
