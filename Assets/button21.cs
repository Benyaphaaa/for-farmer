using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button21 : MonoBehaviour
{
    public void dropdown() //ไฟล์ปุ่มที่เราจะต่อ
    {
        SceneManager.LoadScene("dropdown");
    }
    public void fruit4() //เหมือนกันแค่คนละหน้า
    {
        SceneManager.LoadScene("fruit4");
    }
}
