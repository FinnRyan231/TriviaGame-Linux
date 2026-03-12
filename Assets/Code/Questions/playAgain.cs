using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{

 [SerializeField]
 private FloatSO scoreSO;

void completeQuestion()
    {
        SceneManager.LoadScene(1);
    }

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Invoke("completeQuestion", 1);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
        scoreSO.Value = 0;
    }
}


}