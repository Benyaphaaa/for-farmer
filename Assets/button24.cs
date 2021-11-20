using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button24 : MonoBehaviour
{
    public void fruit1() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("fruit1");
    }
    public void dropdown() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("dropdown");
    }
}

