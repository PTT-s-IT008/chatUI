using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Chat_Project
{   
    partial class User
    {
        private string username;
        private IPAddress user_ip;

        public User()
        {
            this.username = "underfined";
            this.user_ip = IPAddress.Parse("127.0.0.1");
        }
        public void set_username(string username)
        {
            this.username = username;

        }
        public void set_user_ip(IPAddress ip)
        {
            this.user_ip = ip;
        }
        public string get_username()
        {
            return username;
        }
        public IPAddress get_ip()
        {
            return user_ip;
        }
    }
    
    static class Program
    {
       
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_form());
            Application.Run(new Welcome_form());
        }
    }
}
