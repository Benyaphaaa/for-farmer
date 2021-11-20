using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button31 : MonoBehaviour
{
    public void product() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("product");
    }
    public void select() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("select");
    }
}