using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button30 : MonoBehaviour
{
    public void select1() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("select1");
    }
    public void select() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("select");
    }
}

