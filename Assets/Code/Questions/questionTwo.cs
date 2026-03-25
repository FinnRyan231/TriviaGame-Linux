using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Cinemachine;
using TMPro;

public class questionTwo : MonoBehaviour
{
    public GameObject nextQuestion;
    public GameObject currentQuestion;
    public GameObject currentHitbox;
    public GameObject nextHitbox;
    public GameObject wrongAnswer;
    public GameObject audienceCrowd;
    public GameObject tennaTV;
    public GameObject questionNumber;
    public GameObject BG_Regular;
    public GameObject BG_Incorrect;
    public TMP_Text CorrectAnswer;
    public TMP_Text WrongAnswer;
    public TMP_Text WrongAnswerTwo;
    public bool isCorrect;
    public bool animationChanged;

    public Animator animator;


void Awake()
{
   // animator = GetComponent<Animator>();

    if (animator == null)
    {
        Debug.Log("Animator not found");
    }
}


void completeQuestion()
    {
            nextQuestion.SetActive(true);
            nextHitbox.SetActive(true);
            tennaTV.SetActive(true);
            BG_Regular.SetActive(true);
            audienceCrowd.SetActive(true);
            currentQuestion.SetActive(false);
            wrongAnswer.SetActive(false);
            BG_Incorrect.SetActive(false);
            animator.SetBool("isCorrect", false);
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
                animator.SetBool("isCorrect", true);
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                animator.SetBool("animationChanged", true);
                currentHitbox.SetActive(false);
                CorrectAnswer.color = Color.green;

                scoreSO.Value += 100;
                scoreText.text = scoreSO.Value + "";
            }
            else if(gameObject.tag == "Incorrect")
            {

                AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
                tennaTV.SetActive(false);
                audienceCrowd.SetActive(false);
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