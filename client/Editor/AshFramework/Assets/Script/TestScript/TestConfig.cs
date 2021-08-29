using UnityEngine;
using EditorEx.SelectAndDropExtend;

namespace TestEx
{
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

			Debug.Log("ass");
		}
	}

}
