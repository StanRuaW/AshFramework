using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Plugin.Bright.Serialization;
using System.IO;

namespace cfg
{
    //TODO:单个加载，单个卸载，如果有这个需求就弄
    public class ConfigMgr : SingletonMono<ConfigMgr>
    {
		public ai.TbBlackboard TbBlackboard { get; set; }
		public ai.TbBehaviorTree TbBehaviorTree { get; set; }
		public blueprint.TbClazz TbClazz { get; set; }
		public bonus.TbDrop TbDrop { get; set; }
		public common.TbGlobalConfig TbGlobalConfig { get; set; }
		public common.TbDummy TbDummy { get; set; }
		public error.TbErrorInfo TbErrorInfo { get; set; }
		public error.TbCodeInfo TbCodeInfo { get; set; }
		/// <summary>
		/// 道具表
		/// </summary>
		public item.TbItem TbItem { get; set; }
		public item.TbItemFunc TbItemFunc { get; set; }
		public item.TbItemExtra TbItemExtra { get; set; }
		public l10n.TbL10NDemo TbL10NDemo { get; set; }
		public l10n.TbPatchDemo TbPatchDemo { get; set; }
		public mail.TbSystemMail TbSystemMail { get; set; }
		public mail.TbGlobalMail TbGlobalMail { get; set; }
		public role.TbRoleLevelExpAttr TbRoleLevelExpAttr { get; set; }
		public role.TbRoleLevelBonusCoefficient TbRoleLevelBonusCoefficient { get; set; }
		public tag.TbTestTag TbTestTag { get; set; }
		public test.TbFullTypes TbFullTypes { get; set; }
		public test.TbSingleton TbSingleton { get; set; }
		public test.TbDataFromMisc TbDataFromMisc { get; set; }
		public test.TbMultiRowRecord TbMultiRowRecord { get; set; }
		public test.TbMultiRowTitle TbMultiRowTitle { get; set; }
		public test.TbTestNull TbTestNull { get; set; }
		public test.TbDemoPrimitive TbDemoPrimitive { get; set; }
		public test.TbTestString TbTestString { get; set; }
		public test.TbDemoGroup TbDemoGroup { get; set; }
		public test.TbDemoGroup_C TbDemoGroup_C { get; set; }
		public test.TbDemoGroup_S TbDemoGroup_S { get; set; }
		public test.TbDemoGroup_E TbDemoGroup_E { get; set; }
		public test.TbTestGlobal TbTestGlobal { get; set; }
		public test.TbDetectCsvEncoding TbDetectCsvEncoding { get; set; }
		public test.TbDefineFromExcel TbDefineFromExcel { get; set; }
		public test.TbDefineFromExcelOne TbDefineFromExcelOne { get; set; }
		public test.TbTestJson2 TbTestJson2 { get; set; }
		public test.TbTestIndex TbTestIndex { get; set; }
		public test.TbTestMap TbTestMap { get; set; }
		public test.TbDemoGroupDefineFromExcel TbDemoGroupDefineFromExcel { get; set; }
		public test.TbDefineFromExcel2 TbDefineFromExcel2 { get; set; }
		public test.TbTestExcelBean TbTestExcelBean { get; set; }


		protected override void Init()
        {
            base.Init();
            string path = Asset.PathUtil.GetConfigPath();
            LoadAllConfig(file => new ByteBuf(File.ReadAllBytes(path + "/output_data/" + file)));
        }

        protected override void Dispose()
        {
            base.Dispose();
        }

        public void LoadAllConfig(Func<string, ByteBuf> loader)
        {
			var tables = new System.Collections.Generic.Dictionary<string, object>();
			TbBlackboard = new ai.TbBlackboard( loader( "ai_TbBlackboard.bin" ) );
			tables.Add( "ai.TbBlackboard", TbBlackboard );
			TbBehaviorTree = new ai.TbBehaviorTree( loader( "ai_TbBehaviorTree.bin" ) );
			tables.Add( "ai.TbBehaviorTree", TbBehaviorTree );
			TbClazz = new blueprint.TbClazz( loader( "blueprint_TbClazz.bin" ) );
			tables.Add( "blueprint.TbClazz", TbClazz );
			TbDrop = new bonus.TbDrop( loader( "bonus_TbDrop.bin" ) );
			tables.Add( "bonus.TbDrop", TbDrop );
			TbGlobalConfig = new common.TbGlobalConfig( loader( "common_TbGlobalConfig.bin" ) );
			tables.Add( "common.TbGlobalConfig", TbGlobalConfig );
			TbDummy = new common.TbDummy( loader( "common_TbDummy.bin" ) );
			tables.Add( "common.TbDummy", TbDummy );
			TbErrorInfo = new error.TbErrorInfo( loader( "error_TbErrorInfo.bin" ) );
			tables.Add( "error.TbErrorInfo", TbErrorInfo );
			TbCodeInfo = new error.TbCodeInfo( loader( "error_TbCodeInfo.bin" ) );
			tables.Add( "error.TbCodeInfo", TbCodeInfo );
			TbItem = new item.TbItem( loader( "item_TbItem.bin" ) );
			tables.Add( "item.TbItem", TbItem );
			TbItemFunc = new item.TbItemFunc( loader( "item_TbItemFunc.bin" ) );
			tables.Add( "item.TbItemFunc", TbItemFunc );
			TbItemExtra = new item.TbItemExtra( loader( "item_TbItemExtra.bin" ) );
			tables.Add( "item.TbItemExtra", TbItemExtra );
			TbL10NDemo = new l10n.TbL10NDemo( loader( "l10n_TbL10NDemo.bin" ) );
			tables.Add( "l10n.TbL10NDemo", TbL10NDemo );
			TbPatchDemo = new l10n.TbPatchDemo( loader( "l10n_TbPatchDemo.bin" ) );
			tables.Add( "l10n.TbPatchDemo", TbPatchDemo );
			TbSystemMail = new mail.TbSystemMail( loader( "mail_TbSystemMail.bin" ) );
			tables.Add( "mail.TbSystemMail", TbSystemMail );
			TbGlobalMail = new mail.TbGlobalMail( loader( "mail_TbGlobalMail.bin" ) );
			tables.Add( "mail.TbGlobalMail", TbGlobalMail );
			TbRoleLevelExpAttr = new role.TbRoleLevelExpAttr( loader( "role_TbRoleLevelExpAttr.bin" ) );
			tables.Add( "role.TbRoleLevelExpAttr", TbRoleLevelExpAttr );
			TbRoleLevelBonusCoefficient = new role.TbRoleLevelBonusCoefficient( loader( "role_TbRoleLevelBonusCoefficient.bin" ) );
			tables.Add( "role.TbRoleLevelBonusCoefficient", TbRoleLevelBonusCoefficient );
			TbTestTag = new tag.TbTestTag( loader( "tag_TbTestTag.bin" ) );
			tables.Add( "tag.TbTestTag", TbTestTag );
			TbFullTypes = new test.TbFullTypes( loader( "test_TbFullTypes.bin" ) );
			tables.Add( "test.TbFullTypes", TbFullTypes );
			TbSingleton = new test.TbSingleton( loader( "test_TbSingleton.bin" ) );
			tables.Add( "test.TbSingleton", TbSingleton );
			TbDataFromMisc = new test.TbDataFromMisc( loader( "test_TbDataFromMisc.bin" ) );
			tables.Add( "test.TbDataFromMisc", TbDataFromMisc );
			TbMultiRowRecord = new test.TbMultiRowRecord( loader( "test_TbMultiRowRecord.bin" ) );
			tables.Add( "test.TbMultiRowRecord", TbMultiRowRecord );
			TbMultiRowTitle = new test.TbMultiRowTitle( loader( "test_TbMultiRowTitle.bin" ) );
			tables.Add( "test.TbMultiRowTitle", TbMultiRowTitle );
			TbTestNull = new test.TbTestNull( loader( "test_TbTestNull.bin" ) );
			tables.Add( "test.TbTestNull", TbTestNull );
			TbDemoPrimitive = new test.TbDemoPrimitive( loader( "test_TbDemoPrimitive.bin" ) );
			tables.Add( "test.TbDemoPrimitive", TbDemoPrimitive );
			TbTestString = new test.TbTestString( loader( "test_TbTestString.bin" ) );
			tables.Add( "test.TbTestString", TbTestString );
			TbDemoGroup = new test.TbDemoGroup( loader( "test_TbDemoGroup.bin" ) );
			tables.Add( "test.TbDemoGroup", TbDemoGroup );
			TbDemoGroup_C = new test.TbDemoGroup_C( loader( "test_TbDemoGroup_C.bin" ) );
			tables.Add( "test.TbDemoGroup_C", TbDemoGroup_C );
			TbDemoGroup_S = new test.TbDemoGroup_S( loader( "test_TbDemoGroup_S.bin" ) );
			tables.Add( "test.TbDemoGroup_S", TbDemoGroup_S );
			TbDemoGroup_E = new test.TbDemoGroup_E( loader( "test_TbDemoGroup_E.bin" ) );
			tables.Add( "test.TbDemoGroup_E", TbDemoGroup_E );
			TbTestGlobal = new test.TbTestGlobal( loader( "test_TbTestGlobal.bin" ) );
			tables.Add( "test.TbTestGlobal", TbTestGlobal );
			TbDetectCsvEncoding = new test.TbDetectCsvEncoding( loader( "test_TbDetectCsvEncoding.bin" ) );
			tables.Add( "test.TbDetectCsvEncoding", TbDetectCsvEncoding );
			TbDefineFromExcel = new test.TbDefineFromExcel( loader( "test_TbDefineFromExcel.bin" ) );
			tables.Add( "test.TbDefineFromExcel", TbDefineFromExcel );
			TbDefineFromExcelOne = new test.TbDefineFromExcelOne( loader( "test_TbDefineFromExcelOne.bin" ) );
			tables.Add( "test.TbDefineFromExcelOne", TbDefineFromExcelOne );
			TbTestJson2 = new test.TbTestJson2( loader( "test_TbTestJson2.bin" ) );
			tables.Add( "test.TbTestJson2", TbTestJson2 );
			TbTestIndex = new test.TbTestIndex( loader( "test_TbTestIndex.bin" ) );
			tables.Add( "test.TbTestIndex", TbTestIndex );
			TbTestMap = new test.TbTestMap( loader( "test_TbTestMap.bin" ) );
			tables.Add( "test.TbTestMap", TbTestMap );
			TbDemoGroupDefineFromExcel = new test.TbDemoGroupDefineFromExcel( loader( "test_TbDemoGroupDefineFromExcel.bin" ) );
			tables.Add( "test.TbDemoGroupDefineFromExcel", TbDemoGroupDefineFromExcel );
			TbDefineFromExcel2 = new test.TbDefineFromExcel2( loader( "test_TbDefineFromExcel2.bin" ) );
			tables.Add( "test.TbDefineFromExcel2", TbDefineFromExcel2 );
			TbTestExcelBean = new test.TbTestExcelBean( loader( "test_TbTestExcelBean.bin" ) );
			tables.Add( "test.TbTestExcelBean", TbTestExcelBean );

			TbBlackboard.Resolve( tables );
			TbBehaviorTree.Resolve( tables );
			TbClazz.Resolve( tables );
			TbDrop.Resolve( tables );
			TbGlobalConfig.Resolve( tables );
			TbDummy.Resolve( tables );
			TbErrorInfo.Resolve( tables );
			TbCodeInfo.Resolve( tables );
			TbItem.Resolve( tables );
			TbItemFunc.Resolve( tables );
			TbItemExtra.Resolve( tables );
			TbL10NDemo.Resolve( tables );
			TbPatchDemo.Resolve( tables );
			TbSystemMail.Resolve( tables );
			TbGlobalMail.Resolve( tables );
			TbRoleLevelExpAttr.Resolve( tables );
			TbRoleLevelBonusCoefficient.Resolve( tables );
			TbTestTag.Resolve( tables );
			TbFullTypes.Resolve( tables );
			TbSingleton.Resolve( tables );
			TbDataFromMisc.Resolve( tables );
			TbMultiRowRecord.Resolve( tables );
			TbMultiRowTitle.Resolve( tables );
			TbTestNull.Resolve( tables );
			TbDemoPrimitive.Resolve( tables );
			TbTestString.Resolve( tables );
			TbDemoGroup.Resolve( tables );
			TbDemoGroup_C.Resolve( tables );
			TbDemoGroup_S.Resolve( tables );
			TbDemoGroup_E.Resolve( tables );
			TbTestGlobal.Resolve( tables );
			TbDetectCsvEncoding.Resolve( tables );
			TbDefineFromExcel.Resolve( tables );
			TbDefineFromExcelOne.Resolve( tables );
			TbTestJson2.Resolve( tables );
			TbTestIndex.Resolve( tables );
			TbTestMap.Resolve( tables );
			TbDemoGroupDefineFromExcel.Resolve( tables );
			TbDefineFromExcel2.Resolve( tables );
			TbTestExcelBean.Resolve( tables );
		}
		public void TranslateText( System.Func<string, string, string> translator )
		{
			TbBlackboard.TranslateText( translator );
			TbBehaviorTree.TranslateText( translator );
			TbClazz.TranslateText( translator );
			TbDrop.TranslateText( translator );
			TbGlobalConfig.TranslateText( translator );
			TbDummy.TranslateText( translator );
			TbErrorInfo.TranslateText( translator );
			TbCodeInfo.TranslateText( translator );
			TbItem.TranslateText( translator );
			TbItemFunc.TranslateText( translator );
			TbItemExtra.TranslateText( translator );
			TbL10NDemo.TranslateText( translator );
			TbPatchDemo.TranslateText( translator );
			TbSystemMail.TranslateText( translator );
			TbGlobalMail.TranslateText( translator );
			TbRoleLevelExpAttr.TranslateText( translator );
			TbRoleLevelBonusCoefficient.TranslateText( translator );
			TbTestTag.TranslateText( translator );
			TbFullTypes.TranslateText( translator );
			TbSingleton.TranslateText( translator );
			TbDataFromMisc.TranslateText( translator );
			TbMultiRowRecord.TranslateText( translator );
			TbMultiRowTitle.TranslateText( translator );
			TbTestNull.TranslateText( translator );
			TbDemoPrimitive.TranslateText( translator );
			TbTestString.TranslateText( translator );
			TbDemoGroup.TranslateText( translator );
			TbDemoGroup_C.TranslateText( translator );
			TbDemoGroup_S.TranslateText( translator );
			TbDemoGroup_E.TranslateText( translator );
			TbTestGlobal.TranslateText( translator );
			TbDetectCsvEncoding.TranslateText( translator );
			TbDefineFromExcel.TranslateText( translator );
			TbDefineFromExcelOne.TranslateText( translator );
			TbTestJson2.TranslateText( translator );
			TbTestIndex.TranslateText( translator );
			TbTestMap.TranslateText( translator );
			TbDemoGroupDefineFromExcel.TranslateText( translator );
			TbDefineFromExcel2.TranslateText( translator );
			TbTestExcelBean.TranslateText( translator );
		}
		public void UnLoadAllConfig()
        {
			TbBlackboard = null;
			TbBehaviorTree = null;
			TbClazz = null;
			TbDrop = null;
			TbGlobalConfig = null;
			TbDummy = null;
			TbErrorInfo = null;
			TbCodeInfo = null;
			TbItem = null;
			TbItemFunc = null;
			TbItemExtra = null;
			TbL10NDemo = null;
			TbPatchDemo = null;
			TbSystemMail = null;
			TbGlobalMail = null;
			TbRoleLevelExpAttr = null;
			TbRoleLevelBonusCoefficient = null;
			TbTestTag = null;
			TbFullTypes = null;
			TbSingleton = null;
			TbDataFromMisc = null;
			TbMultiRowRecord = null;
			TbMultiRowTitle = null;
			TbTestNull = null;
			TbDemoPrimitive = null;
			TbTestString = null;
			TbDemoGroup = null;
			TbDemoGroup_C = null;
			TbDemoGroup_S = null;
			TbDemoGroup_E = null;
			TbTestGlobal = null;
			TbDetectCsvEncoding = null;
			TbDefineFromExcel = null;
			TbDefineFromExcelOne = null;
			TbTestJson2 = null;
			TbTestIndex = null;
			TbTestMap = null;
			TbDemoGroupDefineFromExcel = null;
			TbDefineFromExcel2 = null;
			TbTestExcelBean = null;
		}
    }

}
