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
    public class LobbyListener : LobbyRequestListener
    {
        Label msgView;
        public LobbyListener(Label msgView)
        {
            this.msgView = msgView;
        }

        public void onJoinLobbyDone(com.shephertz.app42.gaming.multiplayer.client.events.LobbyEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onJoinLobbyDone " + eventObj.getInfo().getName());
            }
            else
            {
                WriteOnUI("onJoinLobbyDone Failed ");
            }
        }

        public void onLeaveLobbyDone(com.shephertz.app42.gaming.multiplayer.client.events.LobbyEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onLeaveLobbyDone " + eventObj.getInfo().getName());
            }
            else
            {
                WriteOnUI("onLeaveLobbyDone Failed ");
            }
        }

        public void onSubscribeLobbyDone(com.shephertz.app42.gaming.multiplayer.client.events.LobbyEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onSubscribeLobbyDone " + eventObj.getInfo().getName());
            }
            else
            {
                WriteOnUI("onSubscribeLobbyDone Failed ");
            }
        }

        public void onUnSubscribeLobbyDone(com.shephertz.app42.gaming.multiplayer.client.events.LobbyEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onUnSubscribeLobbyDone " + eventObj.getInfo().getName());
            }
            else
            {
                WriteOnUI("onUnSubscribeLobbyDone Failed ");
            }
        }

        public void onGetLiveLobbyInfoDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onGetLiveLobbyInfoDone " + eventObj.getData().getName());
            }
            else
            {
                WriteOnUI("onGetLiveLobbyInfoDone Failed ");
            }
        }

        private void WriteOnUI(String message)
        {
            this.msgView.Invoke(new MethodInvoker(() => this.msgView.Text = this.msgView.Text + "\n" + message));
        }
    }
}
