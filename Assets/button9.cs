using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button9 : MonoBehaviour
{
    public void calendar() //�����������Ҩе��
    {
        SceneManager.LoadScene("calendar");
    }
    public void menu() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("menu");
    }
}
