using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button26 : MonoBehaviour
{
    public void fruit3() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("fruit3");
    }
    public void dropdown() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("dropdown");
    }
}
