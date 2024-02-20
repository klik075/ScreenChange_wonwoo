using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public void OnClickLoginButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
