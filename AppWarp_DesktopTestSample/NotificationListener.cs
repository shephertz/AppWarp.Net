using com.shephertz.app42.gaming.multiplayer.client.command;
using com.shephertz.app42.gaming.multiplayer.client.listener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWarp_DesktopTestSample
{
    public class NotificationListener:NotifyListener
    {
        Label msgView;
        public NotificationListener(Label msgView)
        {
            this.msgView = msgView;
        }

        public void onRoomCreated(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj)
        {
            WriteOnUI("onRoomCreated Name "+eventObj.getName()+" Id "+eventObj.getId() + " MaxUsers " + eventObj.getMaxUsers());
        }

        public void onRoomDestroyed(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj)
        {
            WriteOnUI("onRoomDestroyed Name " + eventObj.getName() + " Id " + eventObj.getId() + " MaxUsers " + eventObj.getMaxUsers());
        }

        public void onUserLeftRoom(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj, string username)
        {
            WriteOnUI("onUserLeftRoom Name " + eventObj.getName() + " Id " + eventObj.getId() + " MaxUsers " + eventObj.getMaxUsers() + " username " + username);
        }

        public void onUserJoinedRoom(com.shephertz.app42.gaming.multiplayer.client.events.RoomData eventObj, string username)
        {
            WriteOnUI("onUserJoinedRoom Name " + eventObj.getName() + " Id " + eventObj.getId() + " MaxUsers " + eventObj.getMaxUsers() + " username " + username);
        }

        public void onUserLeftLobby(com.shephertz.app42.gaming.multiplayer.client.events.LobbyData eventObj, string username)
        {
            WriteOnUI("onUserLeftLobby Name " + eventObj.getName() + " Id " + eventObj.getId() + " MaxUsers " + eventObj.getMaxUsers() + " username " + username);
        }

        public void onUserJoinedLobby(com.shephertz.app42.gaming.multiplayer.client.events.LobbyData eventObj, string username)
        {
            WriteOnUI("onUserJoinedLobby Name " + eventObj.getName() + " Id " + eventObj.getId() + " MaxUsers " + eventObj.getMaxUsers() + " username " + username);
        }

        public void onChatReceived(com.shephertz.app42.gaming.multiplayer.client.events.ChatEvent eventObj)
        {
            WriteOnUI(eventObj.getSender() + " sent " + eventObj.getMessage());
        }

        public void onUpdatePeersReceived(com.shephertz.app42.gaming.multiplayer.client.events.UpdateEvent eventObj)
        {
            WriteOnUI("onUpdatePeersReceived " + Encoding.UTF8.GetString(eventObj.getUpdate()) + " fromudp " + eventObj.getIsUdp());
        }

        public void onUserChangeRoomProperty(com.shephertz.app42.gaming.multiplayer.client.events.RoomData roomData, string sender, Dictionary<string, object> properties, Dictionary<string, string> lockedPropertiesTable)
        {
            WriteOnUI("onUserChangeRoomProperty : sender" + roomData.getName() + " sender " + sender);
        }

        public void onPrivateChatReceived(string sender, string message)
        {
            WriteOnUI("onPrivateChatReceived :"+ sender + " sent " + message);
        }

        public void onMoveCompleted(com.shephertz.app42.gaming.multiplayer.client.events.MoveEvent moveEvent)
        {
            WriteOnUI("onMoveCompleted : sender" + moveEvent.getSender() + " Next Turn " + moveEvent.getNextTurn());
        }

        public void onUserPaused(string locid, bool isLobby, string username)
        {
            WriteOnUI("onUserPaused " + locid + " username: " + username+" isLobby "+isLobby);
        }

        public void onUserResumed(string locid, bool isLobby, string username)
        {
            WriteOnUI("onUserResumed " + locid + " username: " + username + " isLobby " + isLobby);
        }

        public void onGameStarted(string sender, string roomId, string nextTurn)
        {
            WriteOnUI("onGameStarted Sender" + sender + " Room Id: " + roomId + " Next Turn " + nextTurn);
        }

        public void onGameStopped(string sender, string roomId)
        {
            WriteOnUI("onGameStopped sender" + sender + " RoomId: " + roomId);
        }

        private void WriteOnUI(String message)
        {
            this.msgView.Invoke(new MethodInvoker(() => this.msgView.Text = this.msgView.Text + "\n" + message));
        }


        public void onPrivateUpdateReceived(string sender, byte[] update, bool fromUdp)
        {
            WriteOnUI("onPrivateUpdateReceived " + sender + " sent " + Encoding.UTF8.GetString(update)+" fromudp "+fromUdp);
        }


        public void onNextTurnRequest(string lastTurn)
        {
            WriteOnUI("onNextTurnRequest lastturn" + lastTurn);
        }
    }
}
