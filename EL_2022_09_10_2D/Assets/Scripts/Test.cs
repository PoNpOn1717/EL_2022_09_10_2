using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��s���ǂݍ���
        using (var fs = new StreamReader(Application.dataPath + "/test.txt", System.Text.Encoding.GetEncoding("UTF-8")))
        {
            while (fs.Peek() != -1)
            {
                Debug.Log(fs.ReadLine());
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
