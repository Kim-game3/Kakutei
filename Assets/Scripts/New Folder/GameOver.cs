using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public bool Over_flag;
    // Start is called before the first frame update
    void Start()
    {
        Over_flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Judge_slope_x()
    {
        if(Player.transform.localEulerAngles.x >= 180 || Player.transform.localEulerAngles.x <= -180)
        {
            SceneManager.LoadScene("Result");
            Over_flag = true;
        }
    }
}
