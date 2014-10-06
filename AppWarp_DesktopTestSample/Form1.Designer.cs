namespace AppWarp_DesktopTestSample
{
    partial class AppWarpCloud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.tbxConnect = new System.Windows.Forms.TextBox();
            this.tbxCreateRoom = new System.Windows.Forms.TextBox();
            this.tbxRoomId = new System.Windows.Forms.TextBox();
            this.tbxPrivateChatUserName = new System.Windows.Forms.TextBox();
            this.btnJoinRoom = new System.Windows.Forms.Button();
            this.btnDisconnect1 = new System.Windows.Forms.Button();
            this.lblResponseMessage = new System.Windows.Forms.Label();
            this.btnInitUdp = new System.Windows.Forms.Button();
            this.btnCustomMessage = new System.Windows.Forms.Button();
            this.btnGetRoomInfo = new System.Windows.Forms.Button();
            this.btnLeaveRoom = new System.Windows.Forms.Button();
            this.btnUnsubscribeRoom = new System.Windows.Forms.Button();
            this.btnSubscribeRoom = new System.Windows.Forms.Button();
            this.btnGetOnlineUsers = new System.Windows.Forms.Button();
            this.btnSubLobby = new System.Windows.Forms.Button();
            this.btnLobbyInfo = new System.Windows.Forms.Button();
            this.btnJoinLobby = new System.Windows.Forms.Button();
            this.btnLeaveLobby = new System.Windows.Forms.Button();
            this.tbxChatMessage = new System.Windows.Forms.TextBox();
            this.tbxMessageCount = new System.Windows.Forms.TextBox();
            this.btnSendUpdate = new System.Windows.Forms.Button();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.btnSendPrivateChat = new System.Windows.Forms.Button();
            this.btnSendPrivateUpdate = new System.Windows.Forms.Button();
            this.tbxRoomIdUpdateProperty = new System.Windows.Forms.TextBox();
            this.tbxPropertyName = new System.Windows.Forms.TextBox();
            this.tbxPropertyValue = new System.Windows.Forms.TextBox();
            this.btnUpdateProperty = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnLockProperty = new System.Windows.Forms.Button();
            this.btnUnlockProperty = new System.Windows.Forms.Button();
            this.btnCreateTurnRoom = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnStopGame = new System.Windows.Forms.Button();
            this.lblNotificationMessage = new System.Windows.Forms.Label();
            this.btnGetMoveHistory = new System.Windows.Forms.Button();
            this.tbxSetNextTurn = new System.Windows.Forms.TextBox();
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.tbxRoomCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(105, 14);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(75, 23);
            this.btnConnect1.TabIndex = 0;
            this.btnConnect1.Text = "connect";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(410, 18);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoom.TabIndex = 1;
            this.btnCreateRoom.Text = "create room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom1_Click);
            // 
            // tbxConnect
            // 
            this.tbxConnect.Location = new System.Drawing.Point(2, 15);
            this.tbxConnect.Name = "tbxConnect";
            this.tbxConnect.Size = new System.Drawing.Size(100, 20);
            this.tbxConnect.TabIndex = 3;
            this.tbxConnect.Text = "username";
            // 
            // tbxCreateRoom
            // 
            this.tbxCreateRoom.Location = new System.Drawing.Point(193, 17);
            this.tbxCreateRoom.Name = "tbxCreateRoom";
            this.tbxCreateRoom.Size = new System.Drawing.Size(100, 20);
            this.tbxCreateRoom.TabIndex = 4;
            this.tbxCreateRoom.Text = "room name";
            // 
            // tbxRoomId
            // 
            this.tbxRoomId.Location = new System.Drawing.Point(2, 47);
            this.tbxRoomId.Name = "tbxRoomId";
            this.tbxRoomId.Size = new System.Drawing.Size(100, 20);
            this.tbxRoomId.TabIndex = 5;
            this.tbxRoomId.Text = "room id";
            // 
            // tbxPrivateChatUserName
            // 
            this.tbxPrivateChatUserName.Location = new System.Drawing.Point(429, 117);
            this.tbxPrivateChatUserName.Name = "tbxPrivateChatUserName";
            this.tbxPrivateChatUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxPrivateChatUserName.TabIndex = 7;
            this.tbxPrivateChatUserName.Text = "user name";
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.Location = new System.Drawing.Point(108, 47);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(75, 23);
            this.btnJoinRoom.TabIndex = 8;
            this.btnJoinRoom.Text = "join room";
            this.btnJoinRoom.UseVisualStyleBackColor = true;
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // btnDisconnect1
            // 
            this.btnDisconnect1.Location = new System.Drawing.Point(702, 18);
            this.btnDisconnect1.Name = "btnDisconnect1";
            this.btnDisconnect1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisconnect1.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect1.TabIndex = 36;
            this.btnDisconnect1.Text = "disconnect";
            this.btnDisconnect1.UseVisualStyleBackColor = true;
            this.btnDisconnect1.Click += new System.EventHandler(this.btnDisconnect1_Click);
            // 
            // lblResponseMessage
            // 
            this.lblResponseMessage.AutoSize = true;
            this.lblResponseMessage.Location = new System.Drawing.Point(6, 183);
            this.lblResponseMessage.Name = "lblResponseMessage";
            this.lblResponseMessage.Size = new System.Drawing.Size(58, 13);
            this.lblResponseMessage.TabIndex = 2;
            this.lblResponseMessage.Text = "Response:";
            // 
            // btnInitUdp
            // 
            this.btnInitUdp.Location = new System.Drawing.Point(545, 83);
            this.btnInitUdp.Name = "btnInitUdp";
            this.btnInitUdp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInitUdp.Size = new System.Drawing.Size(75, 23);
            this.btnInitUdp.TabIndex = 37;
            this.btnInitUdp.Text = "init udp";
            this.btnInitUdp.UseVisualStyleBackColor = true;
            this.btnInitUdp.Click += new System.EventHandler(this.btnInitUdp_Click);
            // 
            // btnCustomMessage
            // 
            this.btnCustomMessage.Location = new System.Drawing.Point(632, 84);
            this.btnCustomMessage.Name = "btnCustomMessage";
            this.btnCustomMessage.Size = new System.Drawing.Size(122, 23);
            this.btnCustomMessage.TabIndex = 38;
            this.btnCustomMessage.Text = "custom message";
            this.btnCustomMessage.UseVisualStyleBackColor = true;
            this.btnCustomMessage.Click += new System.EventHandler(this.btnCtsmMessage_Click);
            // 
            // btnGetRoomInfo
            // 
            this.btnGetRoomInfo.Location = new System.Drawing.Point(197, 48);
            this.btnGetRoomInfo.Name = "btnGetRoomInfo";
            this.btnGetRoomInfo.Size = new System.Drawing.Size(90, 23);
            this.btnGetRoomInfo.TabIndex = 39;
            this.btnGetRoomInfo.Text = "get room info";
            this.btnGetRoomInfo.UseVisualStyleBackColor = true;
            this.btnGetRoomInfo.Click += new System.EventHandler(this.btnGetRoomInfo_Click);
            // 
            // btnLeaveRoom
            // 
            this.btnLeaveRoom.Location = new System.Drawing.Point(393, 51);
            this.btnLeaveRoom.Name = "btnLeaveRoom";
            this.btnLeaveRoom.Size = new System.Drawing.Size(75, 23);
            this.btnLeaveRoom.TabIndex = 40;
            this.btnLeaveRoom.Text = "leave room";
            this.btnLeaveRoom.UseVisualStyleBackColor = true;
            this.btnLeaveRoom.Click += new System.EventHandler(this.btnLeaveRoom_Click);
            // 
            // btnUnsubscribeRoom
            // 
            this.btnUnsubscribeRoom.Location = new System.Drawing.Point(475, 52);
            this.btnUnsubscribeRoom.Name = "btnUnsubscribeRoom";
            this.btnUnsubscribeRoom.Size = new System.Drawing.Size(104, 23);
            this.btnUnsubscribeRoom.TabIndex = 41;
            this.btnUnsubscribeRoom.Text = "unsubscribe room";
            this.btnUnsubscribeRoom.UseVisualStyleBackColor = true;
            this.btnUnsubscribeRoom.Click += new System.EventHandler(this.btnUnsubscribeRoom_Click);
            // 
            // btnSubscribeRoom
            // 
            this.btnSubscribeRoom.Location = new System.Drawing.Point(297, 51);
            this.btnSubscribeRoom.Name = "btnSubscribeRoom";
            this.btnSubscribeRoom.Size = new System.Drawing.Size(90, 23);
            this.btnSubscribeRoom.TabIndex = 42;
            this.btnSubscribeRoom.Text = "subscribe room";
            this.btnSubscribeRoom.UseVisualStyleBackColor = true;
            this.btnSubscribeRoom.Click += new System.EventHandler(this.btnSubscribeRoom_Click);
            // 
            // btnGetOnlineUsers
            // 
            this.btnGetOnlineUsers.Location = new System.Drawing.Point(593, 17);
            this.btnGetOnlineUsers.Name = "btnGetOnlineUsers";
            this.btnGetOnlineUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetOnlineUsers.Size = new System.Drawing.Size(99, 23);
            this.btnGetOnlineUsers.TabIndex = 43;
            this.btnGetOnlineUsers.Text = "get online users";
            this.btnGetOnlineUsers.UseVisualStyleBackColor = true;
            this.btnGetOnlineUsers.Click += new System.EventHandler(this.btnGetOnlineUsers_Click);
            // 
            // btnSubLobby
            // 
            this.btnSubLobby.Location = new System.Drawing.Point(2, 77);
            this.btnSubLobby.Name = "btnSubLobby";
            this.btnSubLobby.Size = new System.Drawing.Size(100, 23);
            this.btnSubLobby.TabIndex = 44;
            this.btnSubLobby.Text = "subscribe lobby";
            this.btnSubLobby.UseVisualStyleBackColor = true;
            this.btnSubLobby.Click += new System.EventHandler(this.btnSubLobby_Click);
            // 
            // btnLobbyInfo
            // 
            this.btnLobbyInfo.Location = new System.Drawing.Point(108, 79);
            this.btnLobbyInfo.Name = "btnLobbyInfo";
            this.btnLobbyInfo.Size = new System.Drawing.Size(100, 23);
            this.btnLobbyInfo.TabIndex = 45;
            this.btnLobbyInfo.Text = "get lobby info";
            this.btnLobbyInfo.UseVisualStyleBackColor = true;
            this.btnLobbyInfo.Click += new System.EventHandler(this.btnLobbyInfo_Click);
            // 
            // btnJoinLobby
            // 
            this.btnJoinLobby.Location = new System.Drawing.Point(214, 79);
            this.btnJoinLobby.Name = "btnJoinLobby";
            this.btnJoinLobby.Size = new System.Drawing.Size(100, 23);
            this.btnJoinLobby.TabIndex = 46;
            this.btnJoinLobby.Text = "join lobby";
            this.btnJoinLobby.UseVisualStyleBackColor = true;
            this.btnJoinLobby.Click += new System.EventHandler(this.btnJoinLobby_Click);
            // 
            // btnLeaveLobby
            // 
            this.btnLeaveLobby.Location = new System.Drawing.Point(320, 81);
            this.btnLeaveLobby.Name = "btnLeaveLobby";
            this.btnLeaveLobby.Size = new System.Drawing.Size(100, 23);
            this.btnLeaveLobby.TabIndex = 47;
            this.btnLeaveLobby.Text = "leave lobby";
            this.btnLeaveLobby.UseVisualStyleBackColor = true;
            this.btnLeaveLobby.Click += new System.EventHandler(this.btnLeaveLobby_Click);
            // 
            // tbxChatMessage
            // 
            this.tbxChatMessage.Location = new System.Drawing.Point(2, 111);
            this.tbxChatMessage.Name = "tbxChatMessage";
            this.tbxChatMessage.Size = new System.Drawing.Size(100, 20);
            this.tbxChatMessage.TabIndex = 48;
            this.tbxChatMessage.Text = "message";
            // 
            // tbxMessageCount
            // 
            this.tbxMessageCount.Location = new System.Drawing.Point(108, 112);
            this.tbxMessageCount.Name = "tbxMessageCount";
            this.tbxMessageCount.Size = new System.Drawing.Size(100, 20);
            this.tbxMessageCount.TabIndex = 49;
            this.tbxMessageCount.Text = "count";
            // 
            // btnSendUpdate
            // 
            this.btnSendUpdate.Location = new System.Drawing.Point(214, 112);
            this.btnSendUpdate.Name = "btnSendUpdate";
            this.btnSendUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnSendUpdate.TabIndex = 50;
            this.btnSendUpdate.Text = "send update";
            this.btnSendUpdate.UseVisualStyleBackColor = true;
            this.btnSendUpdate.Click += new System.EventHandler(this.btnSendUpdate_Click);
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(320, 114);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(100, 23);
            this.btnSendChat.TabIndex = 51;
            this.btnSendChat.Text = "send chat";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnSendPrivateChat
            // 
            this.btnSendPrivateChat.Location = new System.Drawing.Point(532, 116);
            this.btnSendPrivateChat.Name = "btnSendPrivateChat";
            this.btnSendPrivateChat.Size = new System.Drawing.Size(100, 23);
            this.btnSendPrivateChat.TabIndex = 52;
            this.btnSendPrivateChat.Text = "send private chat";
            this.btnSendPrivateChat.UseVisualStyleBackColor = true;
            this.btnSendPrivateChat.Click += new System.EventHandler(this.btnSendPrivateChat_Click);
            // 
            // btnSendPrivateUpdate
            // 
            this.btnSendPrivateUpdate.Location = new System.Drawing.Point(639, 118);
            this.btnSendPrivateUpdate.Name = "btnSendPrivateUpdate";
            this.btnSendPrivateUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnSendPrivateUpdate.TabIndex = 53;
            this.btnSendPrivateUpdate.Text = "send private update";
            this.btnSendPrivateUpdate.UseVisualStyleBackColor = true;
            this.btnSendPrivateUpdate.Click += new System.EventHandler(this.btnSendPrivateUpdate_Click);
            // 
            // tbxRoomIdUpdateProperty
            // 
            this.tbxRoomIdUpdateProperty.Location = new System.Drawing.Point(2, 145);
            this.tbxRoomIdUpdateProperty.Name = "tbxRoomIdUpdateProperty";
            this.tbxRoomIdUpdateProperty.Size = new System.Drawing.Size(100, 20);
            this.tbxRoomIdUpdateProperty.TabIndex = 54;
            this.tbxRoomIdUpdateProperty.Text = "room id";
            // 
            // tbxPropertyName
            // 
            this.tbxPropertyName.Location = new System.Drawing.Point(106, 146);
            this.tbxPropertyName.Name = "tbxPropertyName";
            this.tbxPropertyName.Size = new System.Drawing.Size(100, 20);
            this.tbxPropertyName.TabIndex = 55;
            this.tbxPropertyName.Text = "add property name";
            // 
            // tbxPropertyValue
            // 
            this.tbxPropertyValue.Location = new System.Drawing.Point(211, 146);
            this.tbxPropertyValue.Name = "tbxPropertyValue";
            this.tbxPropertyValue.Size = new System.Drawing.Size(100, 20);
            this.tbxPropertyValue.TabIndex = 56;
            this.tbxPropertyValue.Text = "add property value";
            // 
            // btnUpdateProperty
            // 
            this.btnUpdateProperty.Location = new System.Drawing.Point(432, 147);
            this.btnUpdateProperty.Name = "btnUpdateProperty";
            this.btnUpdateProperty.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateProperty.TabIndex = 57;
            this.btnUpdateProperty.Text = "update property";
            this.btnUpdateProperty.UseVisualStyleBackColor = true;
            this.btnUpdateProperty.Click += new System.EventHandler(this.btnUpdateProperty_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(320, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 58;
            this.textBox4.Text = " remove property";
            // 
            // btnLockProperty
            // 
            this.btnLockProperty.Location = new System.Drawing.Point(535, 148);
            this.btnLockProperty.Name = "btnLockProperty";
            this.btnLockProperty.Size = new System.Drawing.Size(100, 23);
            this.btnLockProperty.TabIndex = 59;
            this.btnLockProperty.Text = "lock property";
            this.btnLockProperty.UseVisualStyleBackColor = true;
            this.btnLockProperty.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnlockProperty
            // 
            this.btnUnlockProperty.Location = new System.Drawing.Point(645, 148);
            this.btnUnlockProperty.Name = "btnUnlockProperty";
            this.btnUnlockProperty.Size = new System.Drawing.Size(100, 23);
            this.btnUnlockProperty.TabIndex = 60;
            this.btnUnlockProperty.Text = "unlock property";
            this.btnUnlockProperty.UseVisualStyleBackColor = true;
            this.btnUnlockProperty.Click += new System.EventHandler(this.btnUnlockProperty_Click);
            // 
            // btnCreateTurnRoom
            // 
            this.btnCreateTurnRoom.Location = new System.Drawing.Point(490, 17);
            this.btnCreateTurnRoom.Name = "btnCreateTurnRoom";
            this.btnCreateTurnRoom.Size = new System.Drawing.Size(94, 23);
            this.btnCreateTurnRoom.TabIndex = 61;
            this.btnCreateTurnRoom.Text = "create turn room";
            this.btnCreateTurnRoom.UseVisualStyleBackColor = true;
            this.btnCreateTurnRoom.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(591, 52);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 62;
            this.btnStartGame.Text = "start game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnStopGame
            // 
            this.btnStopGame.Location = new System.Drawing.Point(679, 52);
            this.btnStopGame.Name = "btnStopGame";
            this.btnStopGame.Size = new System.Drawing.Size(75, 23);
            this.btnStopGame.TabIndex = 63;
            this.btnStopGame.Text = "stop game";
            this.btnStopGame.UseVisualStyleBackColor = true;
            this.btnStopGame.Click += new System.EventHandler(this.btnStopGame_Click);
            // 
            // lblNotificationMessage
            // 
            this.lblNotificationMessage.AutoSize = true;
            this.lblNotificationMessage.Location = new System.Drawing.Point(390, 190);
            this.lblNotificationMessage.Name = "lblNotificationMessage";
            this.lblNotificationMessage.Size = new System.Drawing.Size(68, 13);
            this.lblNotificationMessage.TabIndex = 64;
            this.lblNotificationMessage.Text = "Notifications:";
            // 
            // btnGetMoveHistory
            // 
            this.btnGetMoveHistory.Location = new System.Drawing.Point(429, 84);
            this.btnGetMoveHistory.Name = "btnGetMoveHistory";
            this.btnGetMoveHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetMoveHistory.Size = new System.Drawing.Size(99, 23);
            this.btnGetMoveHistory.TabIndex = 65;
            this.btnGetMoveHistory.Text = "get move history";
            this.btnGetMoveHistory.UseVisualStyleBackColor = true;
            this.btnGetMoveHistory.Click += new System.EventHandler(this.btnGetMoveHistory_Click);
            // 
            // tbxSetNextTurn
            // 
            this.tbxSetNextTurn.Location = new System.Drawing.Point(763, 56);
            this.tbxSetNextTurn.Name = "tbxSetNextTurn";
            this.tbxSetNextTurn.Size = new System.Drawing.Size(100, 20);
            this.tbxSetNextTurn.TabIndex = 66;
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Location = new System.Drawing.Point(866, 55);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(75, 23);
            this.btnNextTurn.TabIndex = 67;
            this.btnNextTurn.Text = "set next turn";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            this.btnNextTurn.Click += new System.EventHandler(this.btnNextTurn_Click);
            // 
            // tbxRoomCount
            // 
            this.tbxRoomCount.Location = new System.Drawing.Point(303, 18);
            this.tbxRoomCount.Name = "tbxRoomCount";
            this.tbxRoomCount.Size = new System.Drawing.Size(100, 20);
            this.tbxRoomCount.TabIndex = 68;
            this.tbxRoomCount.Text = "count";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 17);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AppWarpCloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxRoomCount);
            this.Controls.Add(this.btnNextTurn);
            this.Controls.Add(this.tbxSetNextTurn);
            this.Controls.Add(this.btnGetMoveHistory);
            this.Controls.Add(this.lblNotificationMessage);
            this.Controls.Add(this.btnStopGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnCreateTurnRoom);
            this.Controls.Add(this.btnUnlockProperty);
            this.Controls.Add(this.btnLockProperty);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnUpdateProperty);
            this.Controls.Add(this.tbxPropertyValue);
            this.Controls.Add(this.tbxPropertyName);
            this.Controls.Add(this.tbxRoomIdUpdateProperty);
            this.Controls.Add(this.btnSendPrivateUpdate);
            this.Controls.Add(this.btnSendPrivateChat);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.btnSendUpdate);
            this.Controls.Add(this.tbxMessageCount);
            this.Controls.Add(this.tbxChatMessage);
            this.Controls.Add(this.btnLeaveLobby);
            this.Controls.Add(this.btnJoinLobby);
            this.Controls.Add(this.btnLobbyInfo);
            this.Controls.Add(this.btnSubLobby);
            this.Controls.Add(this.btnGetOnlineUsers);
            this.Controls.Add(this.btnSubscribeRoom);
            this.Controls.Add(this.btnUnsubscribeRoom);
            this.Controls.Add(this.btnLeaveRoom);
            this.Controls.Add(this.btnGetRoomInfo);
            this.Controls.Add(this.btnCustomMessage);
            this.Controls.Add(this.btnInitUdp);
            this.Controls.Add(this.btnDisconnect1);
            this.Controls.Add(this.btnJoinRoom);
            this.Controls.Add(this.tbxPrivateChatUserName);
            this.Controls.Add(this.tbxRoomId);
            this.Controls.Add(this.tbxCreateRoom);
            this.Controls.Add(this.tbxConnect);
            this.Controls.Add(this.lblResponseMessage);
            this.Controls.Add(this.btnCreateRoom);
            this.Controls.Add(this.btnConnect1);
            this.Name = "AppWarpCloud";
            this.Text = "AppWarp cloud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tbxPort1_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnSetPort1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tbxIP1_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.TextBox tbxConnect;
        private System.Windows.Forms.TextBox tbxCreateRoom;
        private System.Windows.Forms.TextBox tbxRoomId;
        private System.Windows.Forms.TextBox tbxPrivateChatUserName;
        private System.Windows.Forms.Button btnJoinRoom;
        private System.Windows.Forms.Button btnDisconnect1;
        private System.Windows.Forms.Label lblResponseMessage;
        private System.Windows.Forms.Button btnInitUdp;
        private System.Windows.Forms.Button btnCustomMessage;
        private System.Windows.Forms.Button btnGetRoomInfo;
        private System.Windows.Forms.Button btnLeaveRoom;
        private System.Windows.Forms.Button btnUnsubscribeRoom;
        private System.Windows.Forms.Button btnSubscribeRoom;
        private System.Windows.Forms.Button btnGetOnlineUsers;
        private System.Windows.Forms.Button btnSubLobby;
        private System.Windows.Forms.Button btnLobbyInfo;
        private System.Windows.Forms.Button btnJoinLobby;
        private System.Windows.Forms.Button btnLeaveLobby;
        private System.Windows.Forms.TextBox tbxChatMessage;
        private System.Windows.Forms.TextBox tbxMessageCount;
        private System.Windows.Forms.Button btnSendUpdate;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Button btnSendPrivateChat;
        private System.Windows.Forms.Button btnSendPrivateUpdate;
        private System.Windows.Forms.TextBox tbxRoomIdUpdateProperty;
        private System.Windows.Forms.TextBox tbxPropertyName;
        private System.Windows.Forms.TextBox tbxPropertyValue;
        private System.Windows.Forms.Button btnUpdateProperty;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnLockProperty;
        private System.Windows.Forms.Button btnUnlockProperty;
        private System.Windows.Forms.Button btnCreateTurnRoom;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnStopGame;
        private System.Windows.Forms.Label lblNotificationMessage;
        private System.Windows.Forms.Button btnGetMoveHistory;
        private System.Windows.Forms.TextBox tbxSetNextTurn;
        private System.Windows.Forms.Button btnNextTurn;
        private System.Windows.Forms.TextBox tbxRoomCount;
        private System.Windows.Forms.Button button1;
    }
}

