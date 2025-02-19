﻿using UnityEngine;

namespace Command.LevelCommands
{
    public class LevelLoaderCommand : MonoBehaviour
    {
        public void InitializeLevel(int _levelID, Transform levelHolder)
        {
            Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level {_levelID}"), levelHolder);
        }
    }
}