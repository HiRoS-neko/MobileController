using System;
using TCPClient;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
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

        private void Update()
        {
            if (captureInput)
            {
                //todo poll the buttons that could be pressed
                
                //todo create a json object out of the input
                string jsonInput = "";
                
                //todo chack to make sure the input is different then the last one sent
                //no point sending the same twice
                
                //give the tcpclient the input
                _tcpClientBackend.SendInput(jsonInput);

            }
        }
    }
}