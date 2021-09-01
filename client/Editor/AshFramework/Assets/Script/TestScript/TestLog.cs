using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AshCommon;
public class TestLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Log.SetLogHelper(new AshFramework.Logger.UnityLogHelper());

		Log.L("hello log");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
