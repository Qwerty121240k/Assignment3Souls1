using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CM
{
    public class CharacterManager : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}