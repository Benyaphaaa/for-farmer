using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button8 : MonoBehaviour
{
    public void menu() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("menu");
    }
    public void beware() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("beware");
    }
}
