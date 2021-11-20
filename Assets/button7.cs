using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button7 : MonoBehaviour
{
    public void beware() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("beware");
    }
    public void gps() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("gps");
    }
}
