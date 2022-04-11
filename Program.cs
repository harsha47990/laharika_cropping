using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laharika_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (systemcheck())
            {
                Application.Run(new main());
                while (true)
                {
                    main temp = new main();
                    if (temp.keyvalue() == "page2")
                    {
                        Application.Run(new Image_Settings());

                    }
                    if (temp.keyvalue() == "close")
                    {
                        break;
                    }
                    if (temp.keyvalue() == "main")
                    { Application.Run(new main()); }

                }

            }
          
            return;
            
        }
        public static bool systemcheck()
        {
            string key="";
            string text = ConfigurationManager.ConnectionStrings["key"].ConnectionString;
            if (File.Exists(text))
            {  key = File.ReadAllText(text); }
            if (key == "qwertyuiopasdfghjklzxcvbnm" || text =="admin")
            {
                return true;
            }
            else
            {
                MessageBox.Show("UNAUTORIZED ACCESS");
                return false;
            }
         
        }
    }
}
