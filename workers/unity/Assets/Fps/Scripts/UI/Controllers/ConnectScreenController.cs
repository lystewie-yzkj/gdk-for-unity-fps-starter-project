﻿using UnityEngine;
using UnityEngine.UI;

namespace Fps
{
    public class ConnectScreenController : MonoBehaviour
    {
        public Button ConnectButton;

        public void Awake()
        {
            ConnectButton.onClick.AddListener(OnConnectClicked);
        }

        public void OnConnectClicked()
        {
            if (ConnectionStateReporter.IsConnected)
            {
            }
            else
            {
                ConnectionStateReporter.SetState(ConnectionStateReporter.State.Connecting);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && ConnectButton.enabled)
            {
                ConnectButton.onClick.Invoke();
            }
        }
    }
}
