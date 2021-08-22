using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLubanReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var tables = new cfg.Tables(file =>
    new Bright.Serialization.ByteBuf(
        System.IO.File.ReadAllBytes("F:/luban/output/bin/"+ file)));


        cfg.item.Item itemInfo = tables.TbItem.Get(1);
        Debug.Log(itemInfo.Id);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
