using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button12 : MonoBehaviour
{
    public void menu() //�����������Ҩе��
    {
        SceneManager.LoadScene("menu");
    }
    public void calendar() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("calendar");
    }
}
