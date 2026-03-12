using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Cinemachine;

public class Quit : MonoBehaviour
{
void completeQuestion()
    {
       SceneManager.LoadScene(0);
    }

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Invoke("completeQuestion", 1);
        CameraShakeManager.Instance.Shake(2f, 1f);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
    }
}


}