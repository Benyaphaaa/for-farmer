using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button25 : MonoBehaviour
{
    public void fruit2() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("fruit2");
    }
    public void dropdown() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("dropdown");
    }
}
