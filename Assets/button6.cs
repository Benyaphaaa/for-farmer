using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button6 : MonoBehaviour
{
    public void confirm() //�����������Ҩе��
    {
        SceneManager.LoadScene("confirm");
    }
    public void fruit() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("fruit");
    }
}
