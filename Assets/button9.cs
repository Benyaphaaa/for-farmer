using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button9 : MonoBehaviour
{
    public void calendar() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("calendar");
    }
    public void menu() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("menu");
    }
}
