using Client.Views;
using System.Windows.Forms;

namespace Client
{
    class Program
    {
        /// <summary>
        /// Client entry point.
        /// Calls the first WinForm, which then calls Client and so on
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Welcome());
        }
    }
}
