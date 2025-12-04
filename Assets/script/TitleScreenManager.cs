using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using CM;


namespace cm
{
    public class TitleScreenManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public void StartNetworkAsHost()
        {
            NetworkManager.Singleton.StartHost();
        }
        public void StartNewGame()
        {
            StartCoroutine(worldSaveGameManager.instence.LoadNewGame());
        }
       
    }
}
