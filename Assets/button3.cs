using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button3 : MonoBehaviour
{
    public void gps() //�����������Ҩе��
    {
        SceneManager.LoadScene("gps");
    }
    public void confirm() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("confirm");
    }
}
