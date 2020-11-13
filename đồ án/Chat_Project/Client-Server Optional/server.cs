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
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SERVER
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//tránh việc đụng độ khi sử dụng tài nguyên giữa các thread
            

        }

        private void server_Load(object sender, EventArgs e)
        {
           
           
        }

      
        private void server_FormClosed(object sender, FormClosedEventArgs e)
        {
            SvClose();
        }
        // khai báo username
        string username;

        IPEndPoint IP;
        Socket ServerSocket;
        //khai báo 1 list các client
        List<Socket> clientList;



        //kết nối đến server
        void Connect()
        {
            clientList = new List<Socket>();//khởi tạo 1 list nhiều client
            //khởi tạo địa chỉ IP và socket để kết nối
            IP = new IPEndPoint(IPAddress.Any, 1997);
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //đợi kết nối từ client
            ServerSocket.Bind(IP);
            //tạo 1 luồng lăng nghe từ client
            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        ServerSocket.Listen(100);
                        Socket client = ServerSocket.Accept();//nếu lăng nghe thành công thì server chấp nhận kết nối
                        clientList.Add(client);//thêm các client được server accept vào list
                        if(IsConnected(client))
                        {
                            ListViewItem ConnectNotice = new ListViewItem();
                            ConnectNotice.ForeColor = Color.Red;

                            ConnectNotice.Text = " A new client has connected at IP : " + client.RemoteEndPoint.ToString();
                            msgListView.Items.Add(ConnectNotice);
                        }
                        //tạo luồng nhận thông tin từ client
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                /*khi kết nối đến n client mà có 1 client disconnect thì server sẽ chạy vòng lặp while liên tục để
                 chương trình ko bị crash*/
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 1997);
                    ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
        // check a client connect
        public bool IsConnected(Socket s)
        {
            try
            {
                return !(s.Poll(1, SelectMode.SelectRead) && s.Available == 0);
            }
            catch (SocketException) { return false; }
        }
        // lấy IP
        string getIPAddress()
        {
            return Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        //đóng kết nối đến server
        void SvClose()
        {   
            if(ServerSocket != null)
            {
                ServerSocket.Close();
            }
           
        }

        //gửi dữ liệu
        void Send(Socket client)
        {
            //nếu textboc khác rỗng thì mới gửi tin
            if ((client != null) && (msgBox.Text != string.Empty))
            {
                client.Send(Serialize(username + " : " + msgBox.Text));
            }
        }

        //nhận dữ liệu
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    //khởi tạo mảng byte để nhận dữ liệu
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    //chuyển data từ dạng byte sang dạng string
                    string message = (string)Deseriliaze(data);

                    //khi 1 client gửi thì cả server và các client (ngoại trừ thằng client vừa gửi) cùng nhận đc
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(Serialize(message));
                        }
                    }

                    AddReceivingMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }


        //add mesage vào khung chat
        void AddSendingMessage(string s)
        {
            ListViewItem msg = new ListViewItem();
            msg.ForeColor = Color.Blue;
            msg.Text = s;
            msgListView.Items.Add(msg);
        }
        // add message nhận được vào khung chat
        void AddReceivingMessage(string s)
        {
            ListViewItem msg = new ListViewItem();
            msg.ForeColor = Color.Black;
            msg.Text = s;
            msgListView.Items.Add(msg);
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
        //gửi tin cho nhiều client
        

        private void SendBtn_Click(object sender, EventArgs e)
        {   if (!string.IsNullOrEmpty(msgBox.Text))
            {
                foreach (Socket item in clientList)
                {
                    Send(item);
                }
                AddSendingMessage(username + " : " + msgBox.Text);
                msgBox.Clear();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nameBox.Text))
            {
                username = nameBox.Text;
                nameBox.Enabled = false;
                confirmButton.Enabled = false;
                msgBox.Enabled = true;
                Connect();

                // add noticed that hosted
                ListViewItem hostNotice = new ListViewItem();
                hostNotice.ForeColor = Color.IndianRed;
                hostNotice.Text = "You hosted a server at IP : " + getIPAddress() + " and port : " + IP.Port.ToString();

                msgListView.Items.Add(hostNotice);
            }
        }
    }
}
