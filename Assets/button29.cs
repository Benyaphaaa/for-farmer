using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button29 : MonoBehaviour
{
    public void select() //�����������Ҩе��
    {
        SceneManager.LoadScene("select");
    }
    public void product() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("product");
    }
}
