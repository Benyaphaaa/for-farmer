using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    public void signup() //�����������Ҩе��
    {
        SceneManager.LoadScene("signup");
    }
    public void login() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("login");
    }
}
