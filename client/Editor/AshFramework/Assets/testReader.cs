using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class testReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        using (var stream = new FileStream("./Assets/table_gen.bin", FileMode.Open))
        {
            stream.Position = 0;
            var reader = new tabtoy.TableReader(stream);
            var tab = new main.Table();

            try
            {
                tab.Deserialize(reader);

            }
            catch(Exception e)
            {
                Debug.LogError(e);
            }

            //tab.IndexData()
            foreach(var kv in tab.MyData)
            {
                Debug.Log(kv.ID + ' ' + kv.Name);
            }
            Debug.Log(tab.MyData[1].ID);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
