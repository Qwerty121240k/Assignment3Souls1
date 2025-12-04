using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
namespace CM
{
    public class playerUiManager : MonoBehaviour
    {   public static playerUiManager instance;


        [Header("NETWORK JOIN")]
        [SerializeField] bool startGameAsClient;
        private void Awake()
        {
            if (instance==null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }


        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }


        private void Update()
        {  
            if(startGameAsClient)
            {
                startGameAsClient = false;
                //we must first shut down because  we have  starded as a host during thetitle scren 
                NetworkManager.Singleton.Shutdown();
                // tthen restart as a cliant 
                NetworkManager.Singleton.StartClient();

            }
        }
    }
}
