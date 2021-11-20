using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button29 : MonoBehaviour
{
    public void select() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("select");
    }
    public void product() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("product");
    }
}
