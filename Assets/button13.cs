using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button13 : MonoBehaviour
{
    public void dropdown() //�����������Ҩе��
    {
        SceneManager.LoadScene("dropdown");
    }
    public void fruit() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("fruit");
    }
}
