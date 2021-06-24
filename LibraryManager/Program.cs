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

            using (var ctx = new AppDbContext())
            {
                bool ctxs = System.Data.Entity.Database.Exists(ctx.Database.Connection);
                if (ctxs == true){
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Auth());
                }   else    {
                    MessageBox.Show("Нет соединения с SQl Server\n Проверьте конфигурацию программы\n Экстренное завершение работы программы", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };

            }

        }

    }
}
