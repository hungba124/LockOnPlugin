﻿using IllusionPlugin;
using UnityEngine;

namespace LockOnPlugin
{
    public class LockOnPlugin : IEnhancedPlugin
    {
        public string Name => GetType().Name;
        public string Version => "1.2.0";

        public string[] Filter => new string[]
        {
            "HoneySelect_32",
            "HoneySelect_64"
        };

        public void OnLevelWasLoaded(int level)
        {
            if(level == 14 && !GameObject.Find("LockOnBehaviour"))
                new GameObject("LockOnBehaviour").AddComponent<LockOnBehaviour>();

            else if(level == 20 && !GameObject.Find("LockOnBehaviourMaker"))
                new GameObject("LockOnBehaviourMaker").AddComponent<LockOnBehaviourMaker>();
        }

        public void OnUpdate(){}
        public void OnLateUpdate(){}
        public void OnApplicationStart(){}
        public void OnApplicationQuit(){}
        public void OnLevelWasInitialized(int level){}
        public void OnFixedUpdate(){}
    }
}