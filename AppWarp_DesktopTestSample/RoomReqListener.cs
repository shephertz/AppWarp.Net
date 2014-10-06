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
    public class RoomReqListener : RoomRequestListener
    {
        Label msgView;
        public RoomReqListener(Label msgView)
        {
            this.msgView = msgView;
        }

        public void onSubscribeRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onSubscribeRoomDone " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onSubscribeRoomDone Failed " + eventObj.getResult());
            }
        }

        public void onUnSubscribeRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onUnSubscribeRoomDone " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onUnSubscribeRoomDone Failed " + eventObj.getResult());
            }
        }

        public void onJoinRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onRoomJoined " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onRoomJoined Failed " + eventObj.getResult());
            }
        }

        public void onLeaveRoomDone(com.shephertz.app42.gaming.multiplayer.client.events.RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onLeaveRoomDone " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onLeaveRoomDone Failed " + eventObj.getResult());
            }
        }

        public void onGetLiveRoomInfoDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onGetLiveRoomInfoDone " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onGetLiveRoomInfoDone Failed " + eventObj.getResult());
            }
        }

        public void onSetCustomRoomDataDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onSetCustomRoomDataDone " + eventObj.getData().getId());
            }
            else
            {
                WriteOnUI("onSetCustomRoomDataDone Failed " + eventObj.getResult());
            }
        }

        public void onUpdatePropertyDone(com.shephertz.app42.gaming.multiplayer.client.events.LiveRoomInfoEvent liveRoomInfoEvent)
        {
            if (liveRoomInfoEvent.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onUpdatePropertyDone " + liveRoomInfoEvent.getData().getId());
            }
            else
            {
                WriteOnUI("onUpdatePropertyDone Failed " + liveRoomInfoEvent.getResult());
            }
        }

        public void onLockPropertiesDone(byte result)
        {
            if (result == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onLockPropertiesDone Success");
            }
            else
            {
                WriteOnUI("onUnlockPropertiesDone Failed");
            }
        }

        public void onUnlockPropertiesDone(byte result)
        {
            if (result == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("onUnlockPropertiesDone Success");
            }
            else
            {
                WriteOnUI("onUnlockPropertiesDone Failed");
            }
        }

        private void WriteOnUI(String message)
        {
            this.msgView.Invoke(new MethodInvoker(() => this.msgView.Text = this.msgView.Text + "\n" + message));
        }
    }
}
