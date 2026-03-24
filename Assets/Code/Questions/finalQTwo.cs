using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class finalQTwo : MonoBehaviour
{
    public GameObject wrongAnswer;
    public GameObject correctAnswer;
    public GameObject tennaTV;
    public GameObject BG_Regular;
    public GameObject BG_Incorrect;
    public GameObject questionNumber;
    public TMP_Text CorrectAnswer;
    public TMP_Text WrongAnswer;
    public TMP_Text WrongAnswerTwo;
    public bool isCorrect;

    public Animator animator;

void Awake()
{
   // animator = GetComponent<Animator>();

    if (animator == null)
    {
        Debug.Log("Animator not found");
    }
}


void finalQuestion()
    {
        SceneManager.LoadScene(2);
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
        Invoke("finalQuestion", 2);
        
        if(gameObject.tag == "Correct")
            {
                animator.SetBool("isCorrect", true);
                Debug.Log("yay");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.correctSFX);
                tennaTV.SetActive(false);
                // questionNumber.SetActive(false);
                // correctAnswer.SetActive(true);
                CorrectAnswer.color = Color.green;
                
                scoreSO.Value += 100;
                scoreText.text = scoreSO.Value + "";


            }
            else if(gameObject.tag == "Incorrect")
            {
                Debug.Log("boo");
                AudioManager.Instance.PlaySFX(AudioManager.Instance.incorrectSFX);
                tennaTV.SetActive(false);
                // questionNumber.SetActive(false);
                // wrongAnswer.SetActive(true);
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