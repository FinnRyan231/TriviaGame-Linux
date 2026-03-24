using UnityEngine;
using System.Collections.Generic;

public class changeAnimation : MonoBehaviour
{
    
    
    
    // questionOne QuestionOne;
    // questionTwo QuestionTwo;
    // questionThree questionThree;
    // private GameObject[] questions;
    private List<GameObject> gameObjects;
    private Animator animator;

    void Awake()
    {
        // questions = GameObject.FindGameObjectsWithTag("Questions");

        // if (questions == null)
        // {
        //     Debug.Log("Questions are not found");
        // }
    }

    // void Update()
    // {
    //     for(int i = 0; i < questions.Length; i++)
    //     {
    //         if(questions[i].isCorrect == true)
    //         {
    //             animator.SetBool("isCorrect", true);
    //         }
    //         else 
    //         {
    //             animator.SetBool("isCorrect", false);
    //         }
            
    //     }
    // }
    
}
