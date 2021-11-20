using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button5 : MonoBehaviour
{
    public void fruit() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("fruit");
    }
    public void select1() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("select1");
    }
}
