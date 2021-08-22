using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConfig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var tables = new cfg.Tables(file =>
    new Bright.Serialization.ByteBuf(
        System.IO.File.ReadAllBytes("./Assets/Config/output_data" + "/" + file)));//TODO:Â·¾¶¹ÜÀí

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
