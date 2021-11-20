using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button22 : MonoBehaviour
{
    public void confirm() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("confirm");
    }
    public void fruit5() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("fruit5");
    }
}

