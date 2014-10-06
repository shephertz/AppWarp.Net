using AppWarp_DesktopTestSample;
using com.shephertz.app42.gaming.multiplayer.client;
using com.shephertz.app42.gaming.multiplayer.client.command;
using com.shephertz.app42.gaming.multiplayer.client.listener;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace AppWarp_WP7_TestSDK
{
    public class MasterListener : MasterRequestListener
    {
        Label msgView;
        TextBox tbxUserName;
        public MasterListener(Label msgView,TextBox tbxusername)
        {
            this.msgView = msgView;
            this.tbxUserName = tbxusername;
        }

        public void onConnectDone(byte result)
        {
            Debug.WriteLine("Master Listener "+result);
            switch (result)
            {
                case WarpResponseResultCode.AUTH_ERROR:
                    //if (eventObj.getReasonCode() == WarpReasonCode.WAITING_FOR_PAUSED_USER)
                    //{
                    //    // int sessionID = (int)DBManager.getDBData("SessionID");
                    //    _page.showResult("Auth Error for paused user ");
                    //    //WarpClient.GetInstance().RecoverConnectionWithSessioId(sessionID, "rahul");
                    //}
                    //else
                    //{
                    //    _page.showResult("Auth Error with reason code " + eventObj.getReasonCode());
                    //    //WarpClient.GetInstance().Connect("rahul");
                    //}
                    break;
                case WarpResponseResultCode.SUCCESS:
                    //DBManager.saveData("SessionID", WarpClient.GetInstance().GetSessionId());
                    //Deployment.Current.Dispatcher.BeginInvoke(() =>
                    //{
                        Debug.WriteLine("connection success");
                        WriteOnUI("connection success");
                        MasterClient.GetInstance().GetAllServers();
                    //});
                    //_page.showResult("connection success");
                    break;
                case WarpResponseResultCode.CONNECTION_ERROR_RECOVERABLE:
                    //_page.showResult("connection recoverable " + eventObj.getResult());
                    // Deployment.Current.Dispatcher.BeginInvoke(delegate() {   RecoverConnection(); });
                    break;
                case WarpResponseResultCode.SUCCESS_RECOVERED:
                    //Debug.WriteLine("Success Recoverd");
                    //_page.showResult("Connect success recoverd: " + eventObj.getResult());
                    break;
                default:
                    Debug.WriteLine("Connection failed");
                    WriteOnUI("connection failed");
                    break;
            }
        }

        public void onDisconnectDone(byte result)
        {
           
        }

        public void onGetAllServerDone(com.shephertz.app42.gaming.multiplayer.client.events.AllServerEvent evnt)
        {
            if (evnt.GetResult() == WarpResponseResultCode.SUCCESS)
            {
                Debug.WriteLine("Get All server done");
                //Deployment.Current.Dispatcher.BeginInvoke(() =>
                //{
                    WarpClient.initialize(evnt.GetServers()[0].GetAppKeys()[0], evnt.GetServers()[0].GetHost(), evnt.GetServers()[0].GetPort());
                    WarpClient.GetInstance().AddConnectionRequestListener(new ConnListener(msgView));
                    WarpClient.GetInstance().AddZoneRequestListener(new ZoneReqListener(msgView));
                    WarpClient.GetInstance().AddRoomRequestListener(new RoomReqListener(msgView));
                    WarpClient.GetInstance().AddNotificationListener(new NotificationListener(msgView));    
                    //WarpClient.setRecoveryAllowance(20);
                    WarpClient.GetInstance().Connect(tbxUserName.Text);
                //});
            }
            else
            {
                Debug.WriteLine("Get All server failed");
            }
        }

        private void WriteOnUI(String message)
        {
            this.msgView.Invoke(new MethodInvoker(() => this.msgView.Text = message));
        }

        public void onCustomMessageReceived(byte[] message)
        {
            Debug.WriteLine(Encoding.UTF8.GetString(message, 0, message.Length));
        }
    }
}
