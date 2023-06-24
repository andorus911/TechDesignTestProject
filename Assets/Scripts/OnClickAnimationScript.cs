using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickAnimationScript : MonoBehaviour
{
    // Private Variables
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Called on click
    private void OnMouseDown()
    {
        if(animator.enabled)
        {
            animator.enabled = false;
        }
        else
        {
            animator.enabled = true;
        }
    }
}
