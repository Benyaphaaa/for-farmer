using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button4 : MonoBehaviour
{
    public void menu() //�����������Ҩе��
    {
        SceneManager.LoadScene("menu");
    }
    public void login() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("login");
    }
}
