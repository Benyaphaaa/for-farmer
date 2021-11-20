using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button28 : MonoBehaviour
{
    public void fruit5() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("fruit5");
    }
    public void dropdown() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("dropdown");
    }
}

