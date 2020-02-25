using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TCPClient
{
    public enum Status
    {
        Starting,
        Running,
        Closed
    }


    public class TCPClientBackend
    {
        private string ipAddress;
        private string deviceID;

        public Status Status;

        public string CurrentInput;
        private bool sendInput;
        private Task tcpClient;


        public TCPClientBackend(string ipAddress)
        {
            Status = Status.Starting;
            deviceID = SystemInfo.deviceUniqueIdentifier;
            this.ipAddress = ipAddress;

            tcpClient = Task.Run(TCPClient);
        }

        private async Task TCPClient()
        {
            try
            {
                Status = Status.Running;
                TcpClient client = new TcpClient(ipAddress, 5953);
                client.NoDelay = true;

                while (client.Connected)
                {
                    if (sendInput == true)
                    {
                        using (NetworkStream stream = client.GetStream())
                        {
                            var message = messageToByteArray(CurrentInput);
                            stream.Write(message, 0, message.Length);
                            sendInput = false;
                        }
                    }

                    await Task.Delay(50);
                }
            }
            catch (Exception e)
            {
            }

            Status = Status.Closed;
        }

        static Encoding encoding = Encoding.UTF8;

        private static byte[] messageToByteArray(string message)
        {
            // get the size of original message
            byte[] messageBytes = encoding.GetBytes(message);
            int messageSize = messageBytes.Length;
            // add content length bytes to the original size
            int completeSize = messageSize + 4;
            // create a buffer of the size of the complete message size
            byte[] completemsg = new byte[completeSize];

            // convert message size to bytes
            byte[] sizeBytes = BitConverter.GetBytes(messageSize);
            // copy the size bytes and the message bytes to our overall message to be sent 
            sizeBytes.CopyTo(completemsg, 0);
            messageBytes.CopyTo(completemsg, 4);
            return completemsg;
        }

        public void SendInput()
        {
            if (sendInput == false)
            {
                sendInput = true;
            }
        }
    }
}