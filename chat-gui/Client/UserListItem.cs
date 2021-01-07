using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class UserListItem : UserControl
    {
        public string username { get; set; }
        public UserListItem()
        {
            InitializeComponent();
        }
        public void validate()
        {
            this.label1.Text = username;
        }

    }
}
