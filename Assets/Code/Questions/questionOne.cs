using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Cinemachine;
using TMPro;

public class questionOne : MonoBehaviour
{
    public GameObject nextQuestion;
    public GameObject currentQuestion;
    public GameObject currentHitbox;
    public GameObject nextHitbox;
    public GameObject wrongAnswer;
    public GameObject correctAnswer;
    public GameObject tennaTV;
    public GameObject questionNumber;
    public GameObject BG_Regular;
    public GameObject BG_Incorrect;
    public TMP_Text CorrectAnswer;
    public TMP_Text WrongAnswer;
    public TMP_Text WrongAnswerTwo;



void completeQuestion()
    {
        nextQuestion.SetActive(true);
        nextHitbox.SetActive(true);
        tennaTV.SetActive(true);
        BG_Regular.SetActive(true);
        currentQuestion.SetActive(false);
        correctAnswer.SetActive(false);
        wrongAnswer.SetActive(false);
        BG_Incorrect.SetActive(false);
    }

    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private FloatSO scoreSO;

    void Start()
    {
    
        scoreText.text = scoreSO.Value + "";
    }

private void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Player")
    {
        Invoke("completeQuestion", 2);

        if(gameObject.tag == "Correct")
            {
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                correctAnswer.SetActive(true);
                currentHitbox.SetActive(false);
                CorrectAnswer.color = Color.green;

                scoreSO.Value += 100;
                scoreText.text = scoreSO.Value + "";


            }
            else if(gameObject.tag == "Incorrect")
            {

                AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
                tennaTV.SetActive(false);
                questionNumber.SetActive(false);
                wrongAnswer.SetActive(true);
                currentHitbox.SetActive(false);
                WrongAnswer.color = Color.red;
                WrongAnswerTwo.color = Color.red;
                
                BG_Incorrect.SetActive(true);
                BG_Regular.SetActive(false);
                CorrectAnswer.color = Color.green;
                CameraShakeManager.Instance.Shake(2f, 1f);
            }
    }
}

}