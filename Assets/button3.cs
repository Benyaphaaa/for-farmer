using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button3 : MonoBehaviour
{
    public void gps() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("gps");
    }
    public void confirm() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("confirm");
    }
}
