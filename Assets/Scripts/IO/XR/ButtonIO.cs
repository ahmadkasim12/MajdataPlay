using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using WindowsInput.Native;

namespace MajdataPlay
{
    public class ButtonIO : MonoBehaviour
    {
        InputSimulator IS;
        Collider collider;
        public VirtualKeyCode keyCode;

        void Start()
        {
            collider = GetComponent<Collider>();
            IS = new InputSimulator();
        }

        private void OnTriggerEnter(Collider other)
        {
            IS.Keyboard.KeyDown(keyCode);
            Debug.Log("Button Pressed By: " + other.gameObject.name);  
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
