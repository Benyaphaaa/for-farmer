using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void login() //�����������Ҩе��
    {
        SceneManager.LoadScene("login");
    }
    public void logo() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("logo");
    }
}
