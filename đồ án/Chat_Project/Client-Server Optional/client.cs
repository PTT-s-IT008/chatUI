using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace CLIENT
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        string username;
        string ip_adress;

        IPEndPoint IP;
        Socket ClientSocket;

        //kết nối đến server
        void Connect(string ip_adress)
        {
            //IP là địa chỉ của server.Khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Parse(ip_adress), 1997);
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //bắt đầu kết nôi. Nếu ko kết nối được thì hiện thông báo
            try
            {
                ClientSocket.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();


        }

        //đóng kết nối đến server
        void Close()
        {   
            if(ClientSocket != null)
            {
                ClientSocket.Close();
            }
           
        }

        //gửi dữ liệu
        void Send()
        {
            //nếu textboc khác rỗng thì mới gửi tin
            if (!string.IsNullOrEmpty(msgBox.Text))
            {
                ClientSocket.Send(Serialize(username + " : " + msgBox.Text));
            }
        }

        //nhận dữ liệu
        void Receive()
        {
            try
            {
                while (true)
                {
                    //khai báo mảng byte để nhận dữ liệu dưới mảng byte
                    byte[] data = new byte[1024 * 5000];
                    ClientSocket.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string message = (string)Deseriliaze(data);
                    AddReceivingMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        //add mesage vào khung chat
        void AddReceivingMessage(string s)
        {
            ListViewItem ReceivingMessage = new ListViewItem();
            ReceivingMessage.ForeColor = Color.Black;
            ReceivingMessage.Text = s;

            msgListview.Items.Add(ReceivingMessage);

        }

        void AddSendingMessage(string s)
        {
            ListViewItem SendingMessage = new ListViewItem();
            SendingMessage.ForeColor = Color.Blue;
            SendingMessage.Text = s;

            msgListview.Items.Add(SendingMessage);
        }

        //Hàm phân mảnh dữ liệu cần gửi từ dạng string sang dạng byte để gửi đi
        byte[] Serialize(object obj)
        {
            //khởi tạo stream để lưu các byte phân mảnh
            MemoryStream stream = new MemoryStream();
            //khởi tạo đối tượng BinaryFormatter để phân mảnh dữ liệu sang kiểu byte
            BinaryFormatter formatter = new BinaryFormatter();
            //phân mảnh rồi ghi vào stream
            formatter.Serialize(stream, obj);
            //từ stream chuyển các các byte thành dãy rồi cbi gửi đi
            return stream.ToArray();
        }

        //Hàm gom mảnh các byte nhận được rồi chuyển sang kiểu string để hiện thị lên màn hình
        object Deseriliaze(byte[] data)
        {
            //khởi tạo stream đọc kết quả của quá trình phân mảnh 
            MemoryStream stream = new MemoryStream(data);
            //khởi tạo đối tượng chuyển đổi
            BinaryFormatter formatter = new BinaryFormatter();
            //chuyển đổi dữ liệu và lưu lại kết quả 
            return formatter.Deserialize(stream);
        }

        private void ConfirmIP_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrEmpty(IPBox.Text))
            {   
                username = nameBox.Text;
                ip_adress = IPBox.Text;

                IPAddress ip;
                if(!IPAddress.TryParse(ip_adress,out ip))
                {
                    MessageBox.Show("Please a valid IP adress","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Connect(ip_adress);
                msgBox.Enabled = true;
                SendBtn.Enabled = true;
                IPBox.Enabled = false;
                nameBox.Enabled = false;
            }
        }

        private void client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            Send();
            AddSendingMessage(username + " : " + msgBox.Text);
            msgBox.Clear();
        }
    }
}
