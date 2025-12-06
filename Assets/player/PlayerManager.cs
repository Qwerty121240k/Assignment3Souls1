using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CM
{
    public class PlayerManager : CharacterManager
    {    PlayerLocomotionManager playerLocomotionManager;
        protected override void Awake()
        {
            base.Awake();
            // do more only player 

            playerLocomotionManager = GetComponent<PlayerLocomotionManager>();
        }
        protected override void Update()
        {
            base.Update();
            //handle movement
            playerLocomotionManager.HandleALLmovement();
        }

    }
}
