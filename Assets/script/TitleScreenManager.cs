using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;


namespace sg
{
    public class TitleScreenManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public void StartNetworkAsHost()
        {
            NetworkManager.Singleton.StartHost();
        }

        // Update is called once per frame
        void Update()
        {
    
        }
    }
}
