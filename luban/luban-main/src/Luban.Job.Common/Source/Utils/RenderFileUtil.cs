using System;

namespace Luban.Job.Common.Utils
{
    public static class RenderFileUtil
    {

        public static string GetDefTypePath(string fullName, ELanguage lan)
        {
            switch (lan)
            {
                case ELanguage.CS: return fullName.Replace('.', '/') + ".cs";
                case ELanguage.JAVA: return fullName.Replace('.', '/') + ".java";
                case ELanguage.CPP: return fullName + ".cpp";
                case ELanguage.GO: return fullName + ".go";
                case ELanguage.LUA: return fullName.Replace('.', '_') + ".lua";
                case ELanguage.JS: return fullName + ".js";
                case ELanguage.TYPESCRIPT: return fullName.Replace('.', '/') + ".ts";
                default: throw new NotSupportedException();
            }

        }

        public static string GetCsDefTypePath(string fullName)
        {
            return fullName.Replace('.', '/') + ".cs";
        }

        public static string GetGoDefTypePath(string fullName)
        {
            return fullName + ".go";
        }

        public static string GetUeCppDefTypeHeaderFilePath(string fullName)
        {
            return fullName.Replace('.', '_') + ".h";
        }

        public static string GetUeCppDefTypeHeaderFilePathWithoutSuffix(string fullName)
        {
            return fullName.Replace('.', '_');
        }


        public static string GetCppDefTypeCppFilePath(string fullName)
        {
            return fullName + ".cpp";
        }

        public static string GetCppDefTypeHeadFilePath(string fullName)
        {
            return fullName + ".h";
        }

        public static string GetTableDataPath(string fullName)
        {
            return fullName + ".bin";
        }

        public static bool IsExcelFile(string fullName)
        {
            return fullName.EndsWith(".csv", StringComparison.Ordinal)
                || fullName.EndsWith(".xls", StringComparison.Ordinal)
                || fullName.EndsWith(".xlsx", StringComparison.Ordinal);
        }

        public static (string, string) SplitFileAndSheetName(string url)
        {
            int sheetSepIndex = url.IndexOf('@');
            if (sheetSepIndex < 0)
            {
                return (url, null);
            }
            else
            {
                int lastPathSep = url.LastIndexOf('/', sheetSepIndex);
                if (lastPathSep >= 0)
                {
                    return (url[0..(lastPathSep + 1)] + url[(sheetSepIndex + 1)..], url[(lastPathSep + 1)..sheetSepIndex]);
                }
                else
                {
                    return (url[(sheetSepIndex + 1)..], url[(lastPathSep + 1)..sheetSepIndex]);
                }
            }
        }
    }
}
