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
        public test.TbFullTypes TbFullTypes { get; set; }
        public test.TbSingleton TbSingleton { get; set; }
        public test.TbDataFromJson TbDataFromJson { get; set; }
        public test.TbDataFromXml TbDataFromXml { get; set; }
        public test.TbDataFromLua TbDataFromLua { get; set; }
        public test.TbMultiRowRecord TbMultiRowRecord { get; set; }
        public test.TbTestNull TbTestNull { get; set; }
        public test.TbTestTag TbTestTag { get; set; }


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
            TbFullTypes = new test.TbFullTypes(loader("test.TbFullTypes.bin"));
            tables.Add("test.TbFullTypes", TbFullTypes);
            TbSingleton = new test.TbSingleton(loader("test.TbSingleton.bin"));
            tables.Add("test.TbSingleton", TbSingleton);
            TbDataFromJson = new test.TbDataFromJson(loader("test.TbDataFromJson.bin"));
            tables.Add("test.TbDataFromJson", TbDataFromJson);
            TbDataFromXml = new test.TbDataFromXml(loader("test.TbDataFromXml.bin"));
            tables.Add("test.TbDataFromXml", TbDataFromXml);
            TbDataFromLua = new test.TbDataFromLua(loader("test.TbDataFromLua.bin"));
            tables.Add("test.TbDataFromLua", TbDataFromLua);
            TbMultiRowRecord = new test.TbMultiRowRecord(loader("test.TbMultiRowRecord.bin"));
            tables.Add("test.TbMultiRowRecord", TbMultiRowRecord);
            TbTestNull = new test.TbTestNull(loader("test.TbTestNull.bin"));
            tables.Add("test.TbTestNull", TbTestNull);
            TbTestTag = new test.TbTestTag(loader("test.TbTestTag.bin"));
            tables.Add("test.TbTestTag", TbTestTag);

            TbFullTypes.Resolve(tables);
            TbSingleton.Resolve(tables);
            TbDataFromJson.Resolve(tables);
            TbDataFromXml.Resolve(tables);
            TbDataFromLua.Resolve(tables);
            TbMultiRowRecord.Resolve(tables);
            TbTestNull.Resolve(tables);
            TbTestTag.Resolve(tables);
        }

        public void UnLoadAllConfig()
        {
            TbFullTypes = null;
            TbSingleton = null;
            TbDataFromJson = null;
            TbDataFromXml = null;
            TbDataFromLua = null;
            TbMultiRowRecord = null;
            TbTestNull = null;
            TbTestTag = null;
        }
    }

}