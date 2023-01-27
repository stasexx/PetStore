using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    public static class Program
    {
        public static readonly SqlConnection SqlConnection = new SqlConnection(@"Data Source=XIAOMI;Initial Catalog=PetStore;Integrated Security=True");
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());
        }
    }
}
