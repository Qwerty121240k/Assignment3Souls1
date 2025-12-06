using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace CM
{
    public class playerInputManager : MonoBehaviour
     {  
        
       public static playerInputManager Instance; 
        
        //read values of joy stick/key 
      // move chaictor based
        PlayerControls playercontrol;
        [SerializeField] Vector2 movementinput;
        private void Awake()
        {   if (Instance == null)
            {
                Instance = this;
            }
            else 
            {
                Destroy(gameObject);
            }
            
        }

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
            //when the scene changes run
            SceneManager.activeSceneChanged += OnSceneChange;
            Instance.enabled = false;
            
        }


        private void OnSceneChange(Scene oldScene, Scene newScene)
        {    //if loading into world scene enable3 controler 
            if (newScene.buildIndex == worldSaveGameManager.instence.getworldSceneindex())
            {
                Instance.enabled = true;
            }
            //else menu disable player 
            //cannot move menu
            else 
            { Instance.enabled = false; }
            }
        

        private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
        {
            throw new System.NotImplementedException();
        }

        private void OnEnable()
        {
            if (playercontrol == null )
            
                {
                playercontrol = new PlayerControls();
                playercontrol.Playermovement.Movement.performed += i => movementinput = i.ReadValue<Vector2>();
                    

                }
            playercontrol.Enable();
        }

        private void OnDestroy()
        { // if we destroy unsubscribe from event 
            SceneManager.activeSceneChanged -= OnSceneChange;
        }

    }
}
