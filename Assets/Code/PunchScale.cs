using UnityEngine;
using DG.Tweening;

public class PunchScale : MonoBehaviour
{
    public void Click()
    {
        transform.DOPunchScale(Vector3.one * 0.2f, 0.3f);
    }

}
