using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button31 : MonoBehaviour
{
    public void product() //�����������Ҩе��
    {
        SceneManager.LoadScene("product");
    }
    public void select() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("select");
    }
}