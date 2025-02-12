using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("前方向へ進むときの速度")]
    [SerializeField] private float Flont;

    [Tooltip("横方向へ進むときの速度")]
    [SerializeField] private float Side;

    [Tooltip("加算される角度")]
    [SerializeField] private float Rad;

    private bool Flag_f = false;
    private bool Flag_fb = false;
    private bool Flag_s = false;
    private bool Flag_sb = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetKey();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void GetKey()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Flag_f = true;
        }
        if(Input.GetKey(KeyCode.S))
        {
            Flag_fb = true;
        }
        if(Input.GetKey(KeyCode.D))
        {
            Flag_s = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Flag_sb = true;
        }
    }

    void Move()
    {
        if (Flag_f)
        {           
            if(Flag_s) 
            {
                transform.Translate(Side, 0, Flont);
                Flag_s = false;
            }
            else if(Flag_sb)
            {
                transform.Translate(-Side, 0, Flont);
                Flag_sb = false;
            }
            else
            {
                transform.Translate(0, 0, Flont);
            }
            Flag_f = false;
        }

        if(Flag_s)
        {
            if(Flag_f)
            {
                transform.Translate(Side, 0, Flont);
                Flag_f = false;
            }
            else if(Flag_fb)
            {
                transform.Translate(Side, 0, -Flont);
                Flag_fb = false;
            }
            else
            {
                transform.Translate(Side, 0, 0);
            }
            Flag_s = false;
        }

        if(Flag_fb)
        {
            if(Flag_s)
            {
                transform.Translate(Side, 0, -Flont);
                Flag_s = false;
            }
            else if(Flag_sb)
            {
                transform.Translate(-Side, 0, -Flont);
                Flag_sb = false;
            }
            else
            {
                transform.Translate(0, 0, -Flont);
            }
            Flag_fb = false;
        }

        if(Flag_sb)
        {
            if(Flag_f)
            {
                transform.Translate(-Side, 0, Flont);
                Flag_f = false;
            }
            else if(Flag_fb)
            {
                transform.Translate(-Side, 0, -Flont);
                Flag_fb = false;
            }
            else
            {
                transform.Translate(-Side, 0, 0);
            }
            Flag_sb = false;
        }
    }

}
