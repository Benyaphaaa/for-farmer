using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button5 : MonoBehaviour
{
    public void fruit() //�����������Ҩе��
    {
        SceneManager.LoadScene("fruit");
    }
    public void select1() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("select1");
    }
}
