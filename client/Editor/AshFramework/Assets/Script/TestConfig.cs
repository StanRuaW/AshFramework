using UnityEngine;
using EditorEx.SelectAndDropExtend;
public class TestConfig : MonoBehaviour
{

    private void Start()
    {
        cfg.ConfigMgr.Inst.Initialize();
    }
}
