//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AshFramework.Log
{
	public class UnityLogHelper :ILogHelper
{
		public void Log(GameFrameworkLogLevel level, object message)
		{
			switch (level)
			{
				case GameFrameworkLogLevel.Debug:
					Debug.Log(message.ToString());
					break;

				case GameFrameworkLogLevel.Info:
					Debug.Log(message.ToString());
					break;

				case GameFrameworkLogLevel.Warning:
					Debug.LogWarning(message.ToString());
					break;

				case GameFrameworkLogLevel.Error:
					Debug.LogError(message.ToString());
					break;
				case GameFrameworkLogLevel.Fatal:
					Debug.LogError("Fatal::"+message.ToString());
					throw new System.Exception("Fatal::"+message.ToString());
			}
		}
	}
}

