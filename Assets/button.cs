using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void login() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("login");
    }
    public void logo() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("logo");
    }
}
