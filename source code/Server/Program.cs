using Server.Views;
using System.Windows.Forms;

namespace Server
{
    /// <summary>
    /// Server entry point, calling the WinForm which calls the Server class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new ServerGUI());
        }
    }
}