using UnityEngine;
using EditorEx.SelectAndDropExtend;
public class TestConfig : MonoBehaviour
{

    private void Start()
    {
        cfg.ConfigMgr.Inst.Initialize();

		Debug.Log( cfg.ai.BehaviorTree.ID );
		cfg.ConfigMgr.Inst.TbItem.ForeachCfg( ( item ) =>
		{
			Debug.Log( item.Desc );
			return true;
		} );
    }
}
