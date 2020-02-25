using System;
using System.IO;
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
        private string _ipAddress;
        private string _deviceId;

        public string SelectedInputType;
        public string MinVersion;

        private string _appVersion;
        
        
        public Status Status;

        private string _currentInput;
        private bool _sendInput;
        private Task tcpClient;


        public TCPClientBackend(string ipAddress, string appVersion)
        {
            Status = Status.Starting;
            _deviceId = SystemInfo.deviceUniqueIdentifier;
            _ipAddress = ipAddress;

            _appVersion = appVersion;
            
            tcpClient = Task.Run(TCPClient);
        }

        private async Task TCPClient()
        {
            try
            {
                Status = Status.Running;
                TcpClient client = new TcpClient(_ipAddress, 5953);
                client.NoDelay = true;

                if (client.Connected)
                {
                    using (NetworkStream stream = client.GetStream())
                    {
                        var connectionResponse = streamToMessage(stream);
                        
                        //todo verify version
                    }
                }
                
                
                while (client.Connected)
                {
                    if (_sendInput == true)
                    {
                        using (NetworkStream stream = client.GetStream())
                        {
                            var message = messageToByteArray(_currentInput);
                            stream.Write(message, 0, message.Length);
                            _sendInput = false;
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

        private static string streamToMessage(Stream stream)
        {
            // size bytes have been fixed to 4
            byte[] sizeBytes = new byte[4];
            // read the content length
            stream.Read(sizeBytes, 0, 4);
            int messageSize = BitConverter.ToInt32(sizeBytes, 0);
            // create a buffer of the content length size and read from the stream
            byte[] messageBytes = new byte[messageSize];
            stream.Read(messageBytes, 0, messageSize);
            // convert message byte array to the message string using the encoding
            string message = encoding.GetString(messageBytes);
            string result = null;
            foreach (var c in message)
                if (c != '\0')
                    result += c;
 
            return result;
        }
        
        public void SendInput(string input)
        {
            if (_sendInput == false)
            {
                _currentInput = input;
                _sendInput = true;
            }
        }
    }
}