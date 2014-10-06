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
    public class ZoneReqListener : ZoneRequestListener
    {
        Label msgView;
        public ZoneReqListener(Label msgView)
        {
            this.msgView = msgView;
        }

        public void onDeleteRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onDeleteRoomDone " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onDeleteRoomDone Failed ");
            }
        }

        public void onGetAllRoomsDone(com.shephertz.app42.gaming.multiplayer.client.events.AllRoomsEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                string[] roomids = eventObj.getRoomIds();
                string roomidlist = "";
                for (int i = 0; i < roomids.Length; i++)
                {
                    roomidlist = roomidlist + "\n" + roomids[i];
                }
                WriteOnUI("Get All Rooms Done room ids:\n" + roomidlist);
            }
            else
            {
                WriteOnUI("Get All Rooms Done Failed ");
            }
        }

        public void onCreateRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("Room Created " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("Room Creation Failed " + eventObj.getResult());
            }
        }

        public void onGetOnlineUsersDone(com.shephertz.app42.gaming.multiplayer.client.events.AllUsersEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                string[] usernames = eventObj.getUserNames();
                string users = "";
                for (int i = 0; i < usernames.Length; i++)
                {
                    users = users + "\n" + usernames[i];
                }
                WriteOnUI("GetOnlineUsers Done " + eventObj.getUserNames());
            }
            else
            {
                WriteOnUI("GetOnlineUsers Failed ");
            }
        }

        public void onGetLiveUserInfoDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveUserInfoEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("GetLiveUserInfo Done room Id: " + eventObj.getLocationId());
            }
            else
            {
                WriteOnUI("GetLiveUserInfo Failed ");
            }
        }

        public void onSetCustomUserDataDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveUserInfoEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("GetLiveUserInfo Done room Id: " + eventObj.getLocationId());
            }
            else
            {
                WriteOnUI("GetLiveUserInfo Failed ");
            }
        }

        public void onGetMatchedRoomsDone(com.shephertz.app42.gaming.multiplayer.client.events.MatchedRoomsEvent matchedRoomsEvent)
        {
            if (matchedRoomsEvent.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onGetMatchedRoomsDone Done room Id: " + matchedRoomsEvent.getRoomsData());
            }
            else
            {
                WriteOnUI("onGetMatchedRoomsDone Failed ");
            }
        }

        //public void onInvokeZoneRPCDone(com.shephertz.app42.gaming.multiplayer.client.events.RPCEvent rpcEvent)
        //{
            
        //}
        private void WriteOnUI(String message)
        {
            this.msgView.Invoke(new MethodInvoker(() => this.msgView.Text = this.msgView.Text + "\n"+message));
        }
    }
}
