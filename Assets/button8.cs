using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button8 : MonoBehaviour
{
    public void menu() //�����������Ҩе��
    {
        SceneManager.LoadScene("menu");
    }
    public void beware() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("beware");
    }
}
