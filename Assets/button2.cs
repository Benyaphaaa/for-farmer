using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button2 : MonoBehaviour
{
    public void product() //�����������Ҩе��
    {
        SceneManager.LoadScene("product");
    }
    public void signup() //����͹�ѹ�褹��˹��
    {
        SceneManager.LoadScene("signup");
    }
}
