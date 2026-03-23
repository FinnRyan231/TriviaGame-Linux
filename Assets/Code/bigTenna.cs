using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bigTenna : MonoBehaviour
{
    public GameObject Tenna_Normal;
    public GameObject Tenna_Static;
    public GameObject currentQuestion;
    public GameObject currentQuestionNumber;

void DeleteStatic()
    {
        Tenna_Static.SetActive(false);
        Tenna_Normal.SetActive(true);
        currentQuestion.SetActive(true);
        currentQuestionNumber.SetActive(true);
    }

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Tenna_Normal.SetActive(false);
        currentQuestion.SetActive(false);
        currentQuestionNumber.SetActive(false);
        Tenna_Static.SetActive(true);
        AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
        Invoke("DeleteStatic", 1);
    }

}

}
