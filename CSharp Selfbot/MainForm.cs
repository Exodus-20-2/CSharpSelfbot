using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Discord;
using Discord.Commands;
using Discord.Gateway;
namespace CSharp_Selfbot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Varibles
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static string prefix { get; set; }
        public static string token  { get; set; }
        public static DiscordSocketClient client = new DiscordSocketClient();
        #endregion
        #region Functions
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void log(string content)
        {
            logs.Items.Add($"[{DateTime.Now.ToString("HH:mm")}] >> {content}");
        }
        private void connect_btn_Click(object sender, EventArgs e)
        {
            prefix = discord_prefix.Text;
            token = discord_token.Text;
            ConnectToAccount.RunWorkerAsync();
        }
        private void ConnectToAccount_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                client.CreateCommandHandler(prefix);
                log("Trying To Connect To The Provided Token");
                client.Login(token);
                log("Connected To Provided Token");
                user_avatar.Load(client.User.Avatar.Url);
                user_name.Text = client.User.Username;
                user_date.Text = client.User.CreatedAt.ToString("dd:MM:yyyy");
                user_status.Text = "Connected";

            }
            catch (Exception ex)
            {
                log("Invalid Token");
                //MessageBox.Show(ex.ToString());
            }
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            logs.Items.Clear();
        }

        private void c_Connect_Click(object sender, EventArgs e)
        {
            prefix = c_Token.Text;
            token = c_Prefix.Text;
            ConnectToAccount.RunWorkerAsync();
        }
        #endregion
    }
}
