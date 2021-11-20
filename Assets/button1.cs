using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button1 : MonoBehaviour
{
    public void signup() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("signup");
    }
    public void login() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("login");
    }
}
