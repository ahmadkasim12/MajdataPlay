using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;

namespace MajdataPlay
{
    public class HandTrigger : MonoBehaviour
    {
        InputSimulator IS;

        // Start is called before the first frame update
        void Start()
        {
            IS = new InputSimulator();
        }

        private void OnTriggerEnter(Collider other)
        {
            IS.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.VK_C);
            Debug.Log("Button Pressed: " + other.gameObject.name);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
