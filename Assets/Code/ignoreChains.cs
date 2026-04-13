using UnityEngine;
using System.Collections;

public class ignoreChains : MonoBehaviour 
{
    //public Transform TVPrefab;
    public LayerMask Chains;
    public LayerMask Background;
    void Start() {
        //Transform TV = Instantiate(TVPrefab) as Transform;
        Physics2D.IgnoreLayerCollision(Chains, Background, true);
        //Physics2D.IgnoreCollision(TV.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }
}