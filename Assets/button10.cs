using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button10 : MonoBehaviour
{
    public void myproduct() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("myproduct");
    }
    public void menu() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("menu");
    }
}
