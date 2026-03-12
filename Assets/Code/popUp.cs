// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Popup : MonoBehaviour
// {
//     PlayerMovement playerMovement;   
//     public GameObject popUp;

//     void Start()
//     {
//         popUp.SetActive(false);
//         playerMovement = this.GetComponent<PlayerMovement>();
//     }

// void tutorial()
//     {
//         popUp.SetActive(true);
//     }

// void delayedTutorial()
// {
//     if(playerMovement.isGrounded == true)
//     {
//         Invoke("tutorial", 5);
//         Debug.Log(playerMovement.isGrounded);
//     }
// }


// }