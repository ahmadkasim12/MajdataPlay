using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MajdataPlay
{
    public class WorldInit : MonoBehaviour
    {
        void LoadInit() { 
            SceneManager.LoadSceneAsync("Init", LoadSceneMode.Additive);
        }
        void Start()
        {
            LoadInit();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
