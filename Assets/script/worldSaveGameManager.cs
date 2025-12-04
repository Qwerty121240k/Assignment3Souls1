using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace CM
{
    public class worldSaveGameManager : MonoBehaviour
    {
        public static worldSaveGameManager instence;
        [SerializeField] int worldsceneIndex = 1;
        private void Awake()
        {   //there can only be one instence of this script as a time if another destroy 
            if (instence == null)
            {
                instence = this;
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

        public IEnumerator LoadNewGame()
        {
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync(worldsceneIndex);
            yield return null;
        }
    }
}
