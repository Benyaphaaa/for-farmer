using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button11 : MonoBehaviour
{
    public void menu() //�����������Ҩе��
    {
        SceneManager.LoadScene("menu");
    }
    public void myproduct() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("myproduct");
    }
}
