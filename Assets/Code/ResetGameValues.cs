using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResetGameValues : MonoBehaviour
{
    [SerializeField]
    private FloatSO scoreSO;
    private void Start()
    {
        scoreSO.Value = 0;
    }
}
