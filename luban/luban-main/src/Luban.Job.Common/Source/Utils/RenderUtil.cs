using Luban.Job.Common.Defs;
using Scriban;
using System;

namespace Luban.Job.Common.Utils
{
    public static class RenderUtil
    {
        [ThreadStatic]
        private static Template t_constRender;
        public static string RenderCsConstClass(DefConst c)
        {
            var ctx = new TemplateContext();
            var env = new TTypeTemplateCommonExtends
            {
                ["x"] = c
            };
            ctx.PushGlobal(env);


            var template = t_constRender ??= Template.Parse(@"
namespace {{x.namespace_with_top_module}}
{
{{~if x.comment != '' ~}}
    /// <summary>
    /// {{x.comment}}
    /// </summary>
{{~end~}}
    public sealed class {{x.name}}
    {
        {{~ for item in x.items ~}}
{{~if item.comment != '' ~}}
        /// <summary>
        /// {{item.comment}}
        /// </summary>
{{~end~}}
        public const {{cs_define_type item.ctype}} {{item.name}} = {{cs_const_value item.ctype item.value}};
        {{~end~}}
    }
}

");
            var result = template.Render(ctx);

            return result;
        }

        [ThreadStatic]
        private static Template t_enumRender;
        public static string RenderCsEnumClass(DefEnum e)
        {
            var template = t_enumRender ??= Template.Parse(@"
namespace {{namespace_with_top_module}}
{
{{~if comment != '' ~}}
    /// <summary>
    /// {{comment}}
    /// </summary>
{{~end~}}
    {{~if is_flags~}}
    [System.Flags]
    {{~end~}}
    public enum {{name}}
    {
        {{~ for item in items ~}}
{{~if item.comment != '' ~}}
        /// <summary>
        /// {{item.comment}}
        /// </summary>
{{~end~}}
        {{item.name}} = {{item.value}},
        {{~end~}}
    }
}


");
            var result = template.Render(e);

            return result;
        }

        [ThreadStatic]
        private static Template t_javaConstRender;
        public static string RenderJavaConstClass(DefConst c)
        {
            var ctx = new TemplateContext();
            var env = new TTypeTemplateCommonExtends
            {
                ["x"] = c
            };
            ctx.PushGlobal(env);


            var template = t_javaConstRender ??= Template.Parse(@"
package {{x.namespace_with_top_module}};

{{~if x.comment != '' ~}}
/**
 * {{x.comment}}
 */
{{~end~}}
public final class {{x.name}}
{
    {{~ for item in x.items ~}}
{{~if item.comment != '' ~}}
    /**
     * {{item.comment}}
     */
{{~end~}}
    public static final {{java_define_type item.ctype}} {{item.name}} = {{java_const_value item.ctype item.value}};
    {{~end~}}
}


");
            var result = template.Render(ctx);

            return result;
        }

        [ThreadStatic]
        private static Template t_javaEnumRender;
        public static string RenderJavaEnumClass(DefEnum e)
        {
            var template = t_javaEnumRender ??= Template.Parse(@"
package {{namespace_with_top_module}};
{{~if comment != '' ~}}
/**
 * {{comment}}
 */
{{~end~}}
public enum {{name}}
{
    {{~ for item in items ~}}
{{~if item.comment != '' ~}}
    /**
     * {{item.comment}}
     */
{{~end~}}
    {{item.name}}({{item.value}}),
    {{~end~}}
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    {{name}}(int value) {
        this.value = value;
    }

    public static {{name}} valueOf(int value) {
    {{~ for item in items ~}}
        if (value == {{item.value}}) return {{item.name}};
    {{~end~}}
        throw new IllegalArgumentException("""");
    }
}

");
            var result = template.Render(e);

            return result;
        }
        [ThreadStatic]
        private static Template t_cppConstRender;
        public static string RenderCppConstClass(DefConst c)
        {
            var ctx = new TemplateContext();
            var env = new TTypeTemplateCommonExtends
            {
                ["x"] = c
            };
            ctx.PushGlobal(env);


            var template = t_cppConstRender ??= Template.Parse(@"
{{x.cpp_namespace_begin}}
{{~if comment != '' ~}}
/**
 * {{comment}}
 */
{{~end~}}
struct {{x.name}}
{
    {{~ for item in x.items ~}}
{{~if item.comment != '' ~}}
    /**
     * {{item.comment}}
    */
{{~end~}}
    static constexpr {{cpp_define_type item.ctype}} {{item.name}} = {{cpp_const_value item.ctype item.value}};
    {{~end~}}
};
{{x.cpp_namespace_end}}

");
            var result = template.Render(ctx);

            return result;
        }

        [ThreadStatic]
        private static Template t_cppEnumRender;
        public static string RenderCppEnumClass(DefEnum e)
        {
            var template = t_cppEnumRender ??= Template.Parse(@"
{{cpp_namespace_begin}}
{{~if comment != '' ~}}
/**
 * {{comment}}
 */
{{~end~}}
enum class {{name}}
{
    {{~ for item in items ~}}
{{~if item.comment != '' ~}}
    /**
     * {{item.comment}}
     */
{{~end~}}
    {{item.name}} = {{item.value}},
    {{~end~}}
};
{{cpp_namespace_end}}
");
            var result = template.Render(e);

            return result;
        }


        [ThreadStatic]
        private static Template t_tsConstRender;
        public static string RenderTypescriptConstClass(DefConst c)
        {
            var ctx = new TemplateContext();
            var env = new TTypeTemplateCommonExtends
            {
                ["x"] = c
            };
            ctx.PushGlobal(env);


            var template = t_tsConstRender ??= Template.Parse(@"
{{x.typescript_namespace_begin}}
{{~if x.comment != '' ~}}
/**
 * {{x.comment}}
 */
{{~end~}}
export class {{x.name}} {
    {{~ for item in x.items ~}}
{{~if item.comment != '' ~}}
    /**
     * {{item.comment}}
     */
{{~end~}}
    static {{item.name}} = {{ts_const_value item.ctype item.value}};
    {{~end~}}
}
{{x.typescript_namespace_end}}

");
            var result = template.Render(ctx);

            return result;
        }

        [ThreadStatic]
        private static Template t_tsEnumRender;
        public static string RenderTypescriptEnumClass(DefEnum e)
        {
            var template = t_tsEnumRender ??= Template.Parse(@"
{{typescript_namespace_begin}}
{{~if comment != '' ~}}
/**
 * {{comment}}
 */
{{~end~}}
export enum {{name}} {
    {{~for item in items ~}}
{{~if item.comment != '' ~}}
    /**
     * {{item.comment}}
     */
{{~end~}}
    {{item.name}} = {{item.value}},
    {{~end~}}
}
{{typescript_namespace_end}}
");
            var result = template.Render(e);

            return result;
        }
    }
}
