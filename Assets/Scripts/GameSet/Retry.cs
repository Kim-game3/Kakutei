using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//�Q�[���̃��g���C
public class Retry : MonoBehaviour
{
    public void Trigger()
    {
        SceneManager.LoadScene("Main");
    }
}
