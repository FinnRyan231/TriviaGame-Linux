using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class throwable : MonoBehaviour
{
    Vector3 throwVector;
    Rigidbody2D _rb;
    LineRenderer _lr;
    PlayerMovement playerMovement;
    private Animator animator;
    void Awake()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        _lr = this.GetComponent<LineRenderer>();
        playerMovement = this.GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
    }
    //onmouse events possible thanks to monobehaviour + collider2d
    void OnMouseDown()
    {
        if(playerMovement.isGrounded == true)
       {
        CalculateThrowVector();
        Path.StartVisualizingPath(this.gameObject);
       }
    }
    void OnMouseDrag()
    {
        if(playerMovement.isGrounded == true)
       {
        CalculateThrowVector();
        Path.VisualizePath(this.gameObject,throwVector * -1); 
       }
    }
    void CalculateThrowVector()
    {
        if(playerMovement.isGrounded == true)
       {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //doing vector2 math to ignore the z values in our distance.
        Vector2 distance = mousePos - this.transform.position;
        //dont normalize the ditance if you want the throw strength to vary
        throwVector = -distance*100;    
       }
    }
    void OnMouseUp()
    {
      if(playerMovement.isGrounded == true)
       {
       Path.StopVisualizingPath(this.gameObject);
        Throw();
       }
    }
    void RemoveArrow()
    {
        _lr.enabled = false;
    }
    public void Throw()
    {
        _rb.AddForce(throwVector * -1);

         if(animator != null)
            { 
                animator.SetBool("isGrounded", playerMovement.isGrounded);
            }
    }

        
    }
 