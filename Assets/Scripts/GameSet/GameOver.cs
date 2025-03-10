using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] Transform player;
    // Start is called before the first frame update
    void Start()
    {
    }

    private bool Is_Side()
    {
        float angle = Vector3.Angle(player.up, Vector3.up);

        return angle >= 90f;
    }

    // Update is called once per frame
    void Update()
    {
        move_Gameover();
    }

    void move_Gameover()
    {
        if(Is_Side())
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    
}
