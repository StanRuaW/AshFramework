using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AshFramework.Log;

namespace AshCommon
{
	//TODO:打包时用宏选择性屏蔽log
	//TODO:这层封装加上ConsoleLogPro的封装，恐怕会有性能问题
	class Log
	{
		private static ILogHelper s_LogHelper = null;

		public static void SetLogHelper(ILogHelper logHelper)
		{
			s_LogHelper = logHelper;
		}

		public static void L(object msg)
		{
			s_LogHelper.Log(GameFrameworkLogLevel.Debug, msg);
		}

		public static void I(object msg)
		{
			s_LogHelper.Log(GameFrameworkLogLevel.Info, msg);
		}

		public static void W(object msg)
		{
			s_LogHelper.Log(GameFrameworkLogLevel.Warning, msg);
		}

		public static void E(object msg)
		{
			s_LogHelper.Log(GameFrameworkLogLevel.Error, msg);
		}

		public static void F(object msg)
		{
			s_LogHelper.Log(GameFrameworkLogLevel.Fatal, msg);
		}
	}
}
