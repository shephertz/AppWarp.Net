using com.shephertz.app42.gaming.multiplayer.client;
using com.shephertz.app42.gaming.multiplayer.client.command;
using com.shephertz.app42.gaming.multiplayer.client.listener;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWarp_DesktopTestSample
{
   public class ConnListener:ConnectionRequestListener
    {
        Label msgView;
        public ConnListener(Label msgView)
        {
            this.msgView = msgView;
        }
        public void onConnectDone(com.shephertz.app42.gaming.multiplayer.client.events.ConnectEvent eventObj)
        {   
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("Connection Success ");
            }
            else
            {
                WriteOnUI("Connection Failed ");
            }
            switch (eventObj.getResult())
            {
                case WarpResponseResultCode.AUTH_ERROR:
                    //if (eventObj.getReasonCode() == WarpReasonCode.WAITING_FOR_PAUSED_USER)
                    //{
                    //    // int sessionID = (int)DBManager.getDBData("SessionID");
                    //    WriteOnUI("Auth Error for paused user ");
                    //    //WarpClient.GetInstance().RecoverConnectionWithSessioId(sessionID, "rahul");
                    //}
                    //else
                    //{
                    //    WriteOnUI("Auth Error with reason code " + eventObj.getReasonCode());
                    //    //WarpClient.GetInstance().Connect("rahul");
                    //}
                    break;
                case WarpResponseResultCode.SUCCESS:
                    //DBManager.saveData("SessionID", WarpClient.GetInstance().GetSessionId());
                    Debug.WriteLine("connection success");
                    //_page.showResult("connection success");
                    break;
                case WarpResponseResultCode.CONNECTION_ERROR_RECOVERABLE:
                    WriteOnUI("connection recoverable " + eventObj.getResult());
                    // Deployment.Current.Dispatcher.BeginInvoke(delegate() {   RecoverConnection(); });
                    break;
                case WarpResponseResultCode.SUCCESS_RECOVERED:
                    Debug.WriteLine("Success Recoverd");
                    WriteOnUI("Connect success recoverd: " + eventObj.getResult());
                    break;
                default:
                    Debug.WriteLine("Connection failed");
                    WriteOnUI("connection failed" + eventObj.getResult());
                    break;
            }
        }

        public void onDisconnectDone(com.shephertz.app42.gaming.multiplayer.client.events.ConnectEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                WriteOnUI("Disconnected " + eventObj.getResult());
            }
            else
            {
                WriteOnUI("Failed " + eventObj.getResult());
            }
        }

        private void WriteOnUI(String message)
        {
            this.msgView.Invoke(new MethodInvoker(() => this.msgView.Text = this.msgView.Text + "\n" + message));
        }
        public void onInitUDPDone(byte resultCode)
        {
            WriteOnUI("Init udp done");
        }


        public void onLog(string msg)
        {
           
        }
    }
}
