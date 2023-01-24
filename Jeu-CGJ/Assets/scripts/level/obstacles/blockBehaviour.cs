using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockBehaviour : MonoBehaviour
{
    
    public parametrableScript param;
    public Rigidbody2D rb;

    void Awake()
    {
        pause();
    }

    public void play()
    {
        rb.gravityScale = 1f;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void reverse()
    {
        rb.gravityScale = -1f;
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    public void pause()
    {
        rb.gravityScale = 0f;
        rb.bodyType = RigidbodyType2D.Static;
    }

    

    public void start()
    {
        if(param.mode == -2)
        {
            play();
        }
        
    }

    public void startAction()
    {
        if(param.mode == 0)
        {
            pause();
        }
        else if(param.mode == -1)
        {
            reverse();
        }
        else
        {
            play();
        }
        
        
    }
}
