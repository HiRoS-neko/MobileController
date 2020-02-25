using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Controls;
using TCPClient;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager GameManagerRef;
        private bool captureInput;

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        private TCPClientBackend _tcpClientBackend;

        void StartTcpClient()
        {
            //todo proper inputs
            _tcpClientBackend = new TCPClientBackend("127.0.0.1", Application.version);
        }

        public void SendInput(ref PolledInput polledInput)
        {
            string xmlString;
            using (var sw = new StringWriter())
            {
                using (var xmlWrite = XmlWriter.Create(sw))
                {
                    XmlSerializer writer = new XmlSerializer(typeof(PolledInput));
                    writer.Serialize(xmlWrite, polledInput);
                }

                xmlString = sw.ToString();
            }

            _tcpClientBackend.SendInput(xmlString);
        }
    }
}