using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriviaManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
    {
        if(gameObject.tag == "ContinueTrivia")
            {
               SceneManager.LoadScene(0);
            }
            else if(gameObject.tag == "EndGame")
            {
                SceneManager.LoadScene(1);
            }
    }
}


}