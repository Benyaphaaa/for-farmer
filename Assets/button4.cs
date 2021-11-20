using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button4 : MonoBehaviour
{
    public void menu() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("menu");
    }
    public void login() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("login");
    }
}
