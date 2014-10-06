using com.shephertz.app42.gaming.multiplayer.client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWarp_DesktopTestSample
{
    public partial class AppWarpCloud : Form
    {
        String CloudAPIKEY = "", CloudSecretKey = "";
        public AppWarpCloud()
        {
            InitializeComponent();
            InitializeWarpClient();
        }

        private void InitializeWarpClient()
        {
            WarpClient.initialize(CloudAPIKEY, CloudSecretKey);
            WarpClient.GetInstance().AddConnectionRequestListener(new ConnListener(lblResponseMessage));
            WarpClient.GetInstance().AddZoneRequestListener(new ZoneReqListener(lblResponseMessage));
            WarpClient.GetInstance().AddRoomRequestListener(new RoomReqListener(lblResponseMessage));
            WarpClient.GetInstance().AddNotificationListener(new NotificationListener(lblNotificationMessage));
            WarpClient.GetInstance().AddTurnBasedRoomRequestListener(new TurnListener(lblResponseMessage));
            WarpClient.GetInstance().AddLobbyRequestListener(new LobbyListener(lblResponseMessage));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().JoinRoom(tbxRoomId.Text);
        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().Connect(tbxConnect.Text);
        }

        private void btnCreateRoom1_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().CreateRoom(tbxCreateRoom.Text, "FirstUser", Convert.ToInt32(tbxRoomCount.Text), null);
        }

        private void btnChat1_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().SendChat(tbxPrivateChatUserName.Text);
        }

     
        private void btnDisconnect1_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().Disconnect();
        }

        private void btnInitUdp_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().initUDP();
        }

        private void btnCtsmMessage_Click(object sender, EventArgs e)
        {
            //MasterClient.GetInstance().sendCustomMessage(Encoding.UTF8.GetBytes(tbxConnect.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().CreateTurnRoom(tbxCreateRoom.Text, "FirstUser", Convert.ToInt32(tbxRoomCount.Text), null, 30);
        }

        private void btnGetOnlineUsers_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().GetOnlineUsers();
        }

        private void btnGetRoomInfo_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().GetLiveRoomInfo(tbxRoomId.Text);
        }

        private void btnSubscribeRoom_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().SubscribeRoom(tbxRoomId.Text);
        }

        private void btnLeaveRoom_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().LeaveRoom(tbxRoomId.Text);
        }

        private void btnUnsubscribeRoom_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().UnsubscribeRoom(tbxRoomId.Text);
        }

        private void btnSubLobby_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().SubscribeLobby();
        }

        private void btnLobbyInfo_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().GetLiveLobbyInfo();
        }

        private void btnJoinLobby_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().JoinLobby();
        }

        private void btnLeaveLobby_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().LeaveLobby();
        }

        private void btnSendUpdate_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().SendUpdatePeers(Encoding.UTF8.GetBytes(tbxChatMessage.Text));
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().SendChat(tbxChatMessage.Text);
        }

        private void btnSendPrivateChat_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().sendPrivateChat(tbxPrivateChatUserName.Text,tbxChatMessage.Text);
        }

        private void btnSendPrivateUpdate_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().sendPrivateUpdate(tbxPrivateChatUserName.Text,Encoding.UTF8.GetBytes(tbxChatMessage.Text));
        }

        private void btnUpdateProperty_Click(object sender, EventArgs e)
        {
            Dictionary<string,object> properties=new Dictionary<string,object>();
            properties.Add(tbxPropertyName.Text,tbxPropertyValue.Text);
            WarpClient.GetInstance().UpdateRoomProperties(tbxRoomIdUpdateProperty.Text, properties, new List<String>());
        }

        private void button1_Click(object sender, EventArgs e)
        {   Dictionary<string,object> properties=new Dictionary<string,object>();
            properties.Add(tbxPropertyName.Text,tbxPropertyValue.Text);
            WarpClient.GetInstance().LockProperties(properties);
        }

        private void btnUnlockProperty_Click(object sender, EventArgs e)
        {
            List<string> properties = new List<string>();
            properties.Add(tbxPropertyName.Text);
            WarpClient.GetInstance().UnlockProperties(properties);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().startGame();
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().stopGame();
        }

        private void btnGetMoveHistory_Click(object sender, EventArgs e)
        {
            WarpClient.GetInstance().getMoveHistory();
        }

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            //WarpClient.GetInstance().SetNextTurn(tbxSetNextTurn.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            lblResponseMessage.Text = "Response :";
            lblNotificationMessage.Text = "Notifications :";
        }

    }
}
