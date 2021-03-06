﻿// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Reflection;
using UnityEditor;
using LuaInterface;
using System.Text;


public class LuaCodeGen : MonoBehaviour
{


    public static string path = "Assets/SLua/LuaObject/";

    


    [MenuItem("SLua/Make")]
    static public void Generate()
    {
        CodeGenerator.InnerTypes.Clear();

        List<string> noUseList = new List<string>
        {      
            "HideInInspector",
            "ExecuteInEditMode",
            "AddComponentMenu",
            "ContextMenu",
            "RequireComponent",
            "DisallowMultipleComponent",
            "SerializeField",
            "AssemblyIsEditorAssembly",
            "Attribute", 
            "Types",
            "UnitySurrogateSelector",
            "TrackedReference",
            "TypeInferenceRules",
            "FFTWindow",
            "RPC",
            "Network",
            "MasterServer",
            "BitStream",
            "HostData",
            "ConnectionTesterStatus",
            "GUI",
            "EventType",
            "EventModifiers",
            "FontStyle",
            "TextAlignment",
            "TextEditor",
            "TextEditorDblClickSnapping",
            "TextGenerator",
            "TextClipping",
            "Gizmos",
             "ADBannerView",
            "ADInterstitialAd",            
            "Android",
            "jvalue",
            "iPhone",
            "iOS",
            "CalendarIdentifier",
            "CalendarUnit",
            "CalendarUnit",
            "FullScreenMovieControlMode",
            "FullScreenMovieScalingMode",
            "Handheld",
            "LocalNotification",
            "Motion",   
            "NotificationServices",
            "RemoteNotificationType",      
            "RemoteNotification",
            "SamsungTV",
            "TextureCompressionQuality",
            "TouchScreenKeyboardType",
            "TouchScreenKeyboard",
            "MovieTexture",
            "UnityEngineInternal",
            "Terrain",                            
            "Tree",
            "SplatPrototype",
            "DetailPrototype",
            "DetailRenderMode",
            "MeshSubsetCombineUtility",
            "AOT",
            "Mathf",
            "Social",
            "Enumerator",       
            "SendMouseEvents",               
            "Cursor",
            "Flash",
            "ActionScript",
        };

        Assembly assembly = Assembly.Load("UnityEngine");
        Type[] types = assembly.GetExportedTypes();

        List<Type> exports = new List<Type>();

        foreach(Type t in types)
        {
            bool export=true;

            foreach (string str in noUseList)
            {
                if (t.FullName.Contains(str))
                    export = false;
            }

            if (export &&!t.IsGenericType && t.BaseType != typeof(System.MulticastDelegate) &&
                !typeof(YieldInstruction).IsAssignableFrom(t) && !IsObsolete(t))
            {
                if(Generate(t))
                    exports.Add(t);
            }
            
        }

        GenerateBind(exports,"LuaUnity");
        
        AssetDatabase.Refresh();
    }

    [MenuItem("SLua/Make UI (for Unity4.6+)")]
    static public void GenerateUI()
    {
        CodeGenerator.InnerTypes.Clear();

        List<string> noUseList = new List<string>
        {      
            "CoroutineTween",
        };

        Assembly assembly = Assembly.Load("UnityEngine.UI");
        Type[] types = assembly.GetExportedTypes();

        List<Type> exports = new List<Type>();

        foreach (Type t in types)
        {
            bool export = true;

            foreach (string str in noUseList)
            {
                if (t.FullName.Contains(str))
                    export = false;
            }

            if (export && !t.IsGenericType && t.BaseType != typeof(System.MulticastDelegate) &&
                !typeof(YieldInstruction).IsAssignableFrom(t) && !IsObsolete(t))
            {
                if(Generate(t))
                    exports.Add(t);
            }

        }

        GenerateBind(exports, "LuaUnityUI");

        AssetDatabase.Refresh();
    }

    static public bool IsObsolete(MemberInfo t)
    {
        return t.GetCustomAttributes(typeof(ObsoleteAttribute), false).Length > 0;
    }

    [MenuItem("SLua/Make custom")]
    static public void Custom()
    {
        List<Type> exports = new List<Type>{
			//typeof(HelloWorld),
		};

        foreach (Type t in exports)
        {
            Generate(t);
        }

        GenerateBind(exports,"LuaCustom");
        AssetDatabase.Refresh();
    }

    [MenuItem("SLua/Clear")]
    static public void Clear()
    {

    }

    static bool Generate(Type t)
    {
        if (t.IsInterface)
            return false;

        CodeGenerator cg = new CodeGenerator();
        cg.Generate(t);
        return true;
    }

    static void GenerateBind(List<Type> list,string name)
    {
        CodeGenerator cg = new CodeGenerator();
        cg.GenerateBind(list,name);
    }

}

class CodeGenerator
{
    static List<string> memberFilter = new List<string>
    {
        "AnimationClip.averageDuration",
        "AnimationClip.averageAngularSpeed",
        "AnimationClip.averageSpeed",
        "AnimationClip.apparentSpeed",
        "AnimationClip.isLooping",
        "AnimationClip.isAnimatorMotion",
        "AnimationClip.isHumanMotion",
        "AnimatorOverrideController.PerformOverrideClipListCleanup",
        "Caching.SetNoBackupFlag",
        "Caching.ResetNoBackupFlag",
        "Light.areaSize",
        "Security.GetChainOfTrustValue",
        "Texture2D.alphaIsTransparency",
        "WWW.movie",
        "WebCamTexture.MarkNonReadable",
        "WebCamTexture.isReadable",
    };

    public static HashSet<string> InnerTypes = new HashSet<string>();
    HashSet<string> funcname = new HashSet<string>();
    int indent = 0;

    public void GenerateBind(List<Type> list,string name)
    {
        HashSet<Type> exported = new HashSet<Type>();
        string f = LuaCodeGen.path + name+".cs";
        StreamWriter file = new StreamWriter(f,false,Encoding.UTF8);
        Write(file, "using System;");
        Write(file, "public static class {0} {{",name);
        Write(file, "public static void Bind(IntPtr l) {");
        foreach (Type t in list)
        {
            WriteBindType(file, t, list, exported);
        }
        Write(file, "}");
        Write(file, "}");
        file.Close();
    }

    void WriteBindType(StreamWriter file, Type t, List<Type> exported, HashSet<Type> binded)
    {
        if (t == null || binded.Contains(t) || !exported.Contains(t))
            return;

        WriteBindType(file, t.BaseType, exported, binded);
        Write(file, "{0}.reg(l);", ExportName(t), binded);
        binded.Add(t);
    }


    public void Generate(Type t)
    {
        if (t.IsEnum)
        {
            StreamWriter file = Begin(t);
            WriteHead(t, file);
            WriteEnumToInt(t, file);
            RegEnumFunction(t, file);
            End(file);
        }
        else
        {
            funcname.Clear();

            StreamWriter file = Begin(t);
            WriteHead(t, file);
            WriteConstructor(t, file);
            WriteFunction(t, file);
            WriteField(t, file);
            RegFunction(t, file);
            End(file);

            if (t.BaseType!=null && t.BaseType.Name=="UnityEvent`1")
            {
                string clsname = ExportName(t);
                string f = LuaCodeGen.path + "LuaUnityEvent_" + GenericName(t.BaseType) + ".cs";
                file = new StreamWriter(f, false, Encoding.UTF8);
                WriteEvent(t, file);
                file.Close();
            }
        }
    }

    void WriteEvent(Type t, StreamWriter file)
    {
        string temp = @"
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLua
{
    public class LuaUnityEvent_$GN : LuaObject
    {

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int AddListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                UnityEngine.Events.UnityAction<$GN> a1;
                checkType(l, 2, out a1);
                self.AddListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int RemoveListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                UnityEngine.Events.UnityAction<$GN> a1;
                checkType(l, 2, out a1);
                self.RemoveListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int Invoke(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                $GN o;
                checkType(l,2,out o);
                self.Invoke(o);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        static public void reg(IntPtr l)
        {
            getTypeTable(l, typeof(LuaUnityEvent_$GN).FullName);
            addMember(l, AddListener);
            addMember(l, RemoveListener);
            addMember(l, Invoke);
            createTypeMetatable(l, typeof(LuaUnityEvent_$GN));
            LuaDLL.lua_pop(l, 1);
        }

        static bool checkType(IntPtr l,int p,out UnityEngine.Events.UnityAction<$GN> ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = ($GN v) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);
                pushValue(l, v);
                if (LuaDLL.lua_pcall(l, 1, 0, error) != 0)
                {
                    LuaDLL.lua_pop(l, 1); // pop error msg
                }
                LuaDLL.lua_pop(l, 1); // pop error function
            };
            return true;
        }
    }
}";


        temp = temp.Replace("$CLS", ExportName(t));
        temp = temp.Replace("$FNAME", FullName(t));
        temp = temp.Replace("$GN", GenericName(t.BaseType));
        Write(file, temp);
    }

    void WriteEnumToInt(Type t, StreamWriter file)
    {
        WriteFunctionAttr(file);
        Write(file, "static int IntToEnum(IntPtr l) {");
        Write(file, "int v = LuaDLL.lua_tointeger(l, 1);");
		Write(file, "{0} o = ({0})v;",FullName(t));
        Write(file, "pushValue(l,o);");
		Write(file,"return 1;");
        Write(file,"}");
	}

    void RegEnumFunction(Type t, StreamWriter file)
    {
        // Write export function
        Write(file, "static public void reg(IntPtr l) {");
        Write(file, "getTypeTable(l,\"{0}\");", FullName(t));

        FieldInfo[] fields = t.GetFields();
        foreach (FieldInfo f in fields)
        {
            if (f.Name == "value__") continue;
            Write(file, "LuaDLL.lua_pushinteger(l, {0});", (int)f.GetValue(null));
            Write(file, "LuaDLL.lua_setfield(l, -2, \"{0}\");",f.Name);
        }

        Write(file, "addMember(l,IntToEnum, \"IntToEnum\");" );
        Write(file, "LuaDLL.lua_pop(l, 1);");
        Write(file, "}");
    }


    StreamWriter Begin(Type t)
    {
        string clsname = ExportName(t);
        string f = LuaCodeGen.path + clsname + ".cs";
        StreamWriter file = new StreamWriter(f, false, Encoding.UTF8);
        return file;
    }
    private void End(StreamWriter file)
    {
        Write(file, "}");
        file.Flush();
        file.Close();
    }

    private void WriteHead(Type t,StreamWriter file)
    {
        Write(file, "using UnityEngine;");
        Write(file, "using System;");
        Write(file, "using LuaInterface;");
        Write(file, "using SLua;");
        Write(file, "using System.Collections.Generic;");
        Write(file, "public class {0} : LuaObject {{", ExportName(t));
        //Write(file, "static public List<LuaCSFunction> exportfuncs = new List<LuaCSFunction>();");
    }
    

    private void WriteFunction(Type t, StreamWriter file)
    {
        Dictionary<string, int> renamefunc = new Dictionary<string, int>();
        BindingFlags bf = BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance|BindingFlags.DeclaredOnly;
        MethodInfo[] members = t.GetMethods( bf );
        foreach (MethodInfo mi in members)
        {
            if (mi.MemberType == MemberTypes.Method && !funcname.Contains(mi.Name) && isUsefullMethod(mi))
            {
                if (!renamefunc.ContainsKey(mi.Name)) renamefunc[mi.Name] = 0;
                renamefunc[mi.Name] += 1;
            }
        }

        foreach (MethodInfo mi in members)
        {

            if (mi.MemberType == MemberTypes.Method
                && !IsObsolete(mi)
                && !funcname.Contains(mi.Name)
                && isUsefullMethod(mi)
                && !MemberInFilter(t, mi))
            {
                WriteFunctionDec(file, mi.Name);
                WriteFunctionImpl(file, mi, t, renamefunc[mi.Name]);
                funcname.Add(mi.Name);
            }
        }
    }


    bool MemberInFilter(Type t, MemberInfo mi)
    {
        return memberFilter.Contains(t.Name + "." + mi.Name);
    }

    bool IsObsolete(MemberInfo mi)
    {
        return LuaCodeGen.IsObsolete(mi);
    }

    void RegFunction(Type t, StreamWriter file)
    {
        // Write export function
        Write(file, "static public void reg(IntPtr l) {");

        if (t.BaseType != null && t.BaseType.Name=="UnityEvent`1")
        {
            Write(file, "LuaUnityEvent_{1}.reg(l);", FullName(t), GenericName(t.BaseType));
        }

        Write(file, "getTypeTable(l,\"{0}\");", FullName(t));
        foreach (string f in funcname)
        {
            Write(file, "addMember(l,{0}, \"{0}\");", f);
        }
        Write(file, "newType(l, constructor);");
        if (t.BaseType != null && !CutBase(t.BaseType))
        {
            if(t.BaseType.Name=="UnityEvent`1")
                Write(file, "createTypeMetatable(l, typeof({0}),typeof(LuaUnityEvent_{1}));", FullName(t),GenericName(t.BaseType));
            else
                Write(file, "createTypeMetatable(l, typeof({0}),typeof({1}));", FullName(t), FullName(t.BaseType));
        }
        else
            Write(file, "createTypeMetatable(l, typeof({0}));", FullName(t));
        Write(file, "LuaDLL.lua_pop(l, 1);");
        Write(file, "}");
    }

    bool CutBase(Type t)
    {
        if (t.FullName.Contains("System."))
            return true;
        return false;
    }

    private void WriteField(Type t, StreamWriter file)
    {
        // Write field set/get

        FieldInfo[] fields = t.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance|BindingFlags.DeclaredOnly);
        foreach (FieldInfo fi in fields)
        {
            WriteFunctionAttr(file);
            Write(file, "static public int get_{0}(IntPtr l) {{", fi.Name);

            if (fi.IsStatic)
            {
                WritePushValue(fi.FieldType, file, string.Format("{0}.{1}", t.FullName, fi.Name));
            }
            else
            {
                Write(file, "{0} o = checkSelf<{0}>(l);", FullName(t));
                WritePushValue(fi.FieldType, file, string.Format("o.{0}", fi.Name));
            }

            Write(file, "return 1;");
            Write(file, "}");

            funcname.Add("get_" + fi.Name);

            if (!fi.IsLiteral && !fi.IsInitOnly)
            {
                WriteFunctionAttr(file);
                Write(file, "static public int set_{0}(IntPtr l) {{", fi.Name);

                if (fi.IsStatic)
                {
                    Write(file, "{0} v;", TypeDecl(fi.FieldType));
                    WriteCheckType(fi.FieldType, file, 2);
                    Write(file, "{0}.{1}=v;", t.FullName, fi.Name);
                }
                else
                {
                    Write(file, "{0} o = checkSelf<{0}>(l);", FullName(t));
                    Write(file, "{0} v;", TypeDecl(fi.FieldType));
                    WriteCheckType(fi.FieldType, file, 2);
                    Write(file, "o.{0}=v;", fi.Name);
                }

                if(t.IsValueType && !fi.IsStatic)
                    Write(file, "setBack(l,o);");
                Write(file, "return 0;");
                Write(file, "}");
                funcname.Add("set_" + fi.Name);
            }

        }

        // Write property set/get
        PropertyInfo[] props = t.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (PropertyInfo fi in props)
        {
            if (fi.Name == "Item" || IsObsolete(fi) || MemberInFilter(t,fi))
                continue;

            if (fi.CanRead)
            {
                WriteFunctionAttr(file);
                Write(file, "static public int get_{0}(IntPtr l) {{", fi.Name);

                if (IsNotSupport(fi.PropertyType))
                {
                    NotSupport(file);
                }
                else
                {
                    if (fi.GetGetMethod().IsStatic)
                        WritePushValue(fi.PropertyType, file, string.Format("{0}.{1}", t.FullName, fi.Name));
                    else
                    {
                        Write(file, "{0} o = checkSelf<{0}>(l);", FullName(t));
                        WritePushValue(fi.PropertyType, file, string.Format("o.{0}", fi.Name));
                    }

                    Write(file, "return 1;");
                }
                Write(file, "}");
                funcname.Add("get_" + fi.Name);
            }

            if (fi.CanWrite && fi.GetSetMethod()!=null)
            {
                WriteFunctionAttr(file);
                Write(file, "static public int set_{0}(IntPtr l) {{", fi.Name);

                if (IsNotSupport(fi.PropertyType))
                    NotSupport(file);
                else
                {
                    if (fi.GetSetMethod().IsStatic)
                    {
                        Write(file, "{0} v;", TypeDecl(fi.PropertyType));
                        WriteCheckType(fi.PropertyType, file, 2);
                        Write(file, "{0}.{1}=v;", t.FullName, fi.Name);
                    }
                    else
                    {
                        Write(file, "{0} o = checkSelf<{0}>(l);", FullName(t));
                        Write(file, "{0} v;", TypeDecl(fi.PropertyType));
                        WriteCheckType(fi.PropertyType, file, 2);
                        Write(file, "o.{0}=v;", fi.Name);
                    }

                    if (t.IsValueType)
                        Write(file, "setBack(l,o);");

                    Write(file, "return 0;");
                }
                Write(file, "}");
                funcname.Add("set_" + fi.Name);
            }
        }
    }

    void WriteCheckType(Type t, StreamWriter file, int n)
    {
        Write(file, "checkType(l,{0},out v);", n);
    }

    private void WriteFunctionAttr(StreamWriter file)
    {
        Write(file, "[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]");
    }

    private void WriteConstructor(Type t, StreamWriter file)
    {
        WriteFunctionAttr(file);
        Write(file, "static public int constructor(IntPtr l) {");
        ConstructorInfo[] cons = t.GetConstructors();
        if (cons.Length > 0)
        {
            Write(file, "LuaDLL.lua_remove(l,1);");
            Write(file, "{0} o;", FullName(t));
            bool first = true;
            for (int n = 0; n < cons.Length; n++)
            {
                ConstructorInfo ci = cons[n];
                ParameterInfo[] pars = ci.GetParameters();
                if (!containGeneric(pars))
                {
                    Write(file, "{0}(matchType(l,1{1})){{", first ? "if" : "else if", TypeDecl(pars));
                    // pre-check is parameter is delegate
                    for (int k = 0; k < pars.Length; k++)
                    {
                        if (IsNotSupport(pars[k].ParameterType))
                        {
                            NotSupport(file);

                            break;
                        }
                    }

                    for (int k = 0; k < pars.Length; k++)
                    {
                        CheckArgument(file, pars[k].ParameterType, k, 1, false);
                    }
                    Write(file, "o=new {0}({1});", FullName(t), FuncCall(ci));
                    Write(file, "pushObject(l,o);");
                    Write(file, "return 1;");
                    Write(file, "}");
                    first = false;
                }
            }
        }
        Write(file, "return 0;");
        Write(file, "}");
    }

    private void NotSupport(StreamWriter file)
    {
        Write(file, "LuaDLL.luaL_error(l,\"Not support\");");
        Write(file, "return 0;");
    }
    bool IsNotSupport(Type t)
    {
        if (t.IsSubclassOf(typeof(Delegate)))
            return true;
        return false;
    }

    string[] prefix = new string[] { "System.Collections.Generic" };
	string RemoveRef(string s)
	{
		return RemoveRef (s, true);
	}
    string RemoveRef(string s, bool removearray)
    {
        if (s.EndsWith("&")) s = s.Substring(0, s.Length - 1);
        if (s.EndsWith("[]") && removearray) s = s.Substring(0, s.Length - 2);
        if (s.StartsWith(prefix[0])) s = s.Substring(prefix[0].Length+1, s.Length - prefix[0].Length-1);
        
        s = s.Replace("+", ".");
        if (s.Contains("`"))
        {
            s = s.Replace("`1", "");
            s = s.Replace("`2", "");
            s = s.Replace("[", "<");
            s = s.Replace("]", ">");
        }
        return s;
    }

    string GenericName(Type t)
    {
        try
        {
            string s = t.ToString();
            int start = s.IndexOf('[')+1;
            int end = s.IndexOf(']');
            s = s.Substring(start, end - start);
            s = s.Substring(s.LastIndexOf('.')+1);
            return s;
        }
        catch (Exception e)
        {
            Debug.Log(e.ToString());
            return "";
        }
    }

    string TypeDecl(ParameterInfo[] pars)
    {
        string ret = "";
        for (int n = 0; n < pars.Length; n++)
        {
            ret += ",typeof(";
            ret += FullName(pars[n].ParameterType);
            ret += ")";
        }
        return ret;
    }

    bool isUsefullMethod(MethodInfo method)
    {
        if (method.Name != "GetType" && method.Name != "GetHashCode" && method.Name != "Equals" &&
            method.Name != "ToString" && method.Name != "Clone" && method.Name != "Dispose" &&
            method.Name != "GetEnumerator" && method.Name != "CopyTo" &&
            method.Name != "op_Implicit" &&
            !method.Name.StartsWith("get_", StringComparison.Ordinal) &&
            !method.Name.StartsWith("set_", StringComparison.Ordinal) &&
            !method.Name.StartsWith("add_", StringComparison.Ordinal) &&
            //!method.Name.StartsWith("op_", StringComparison.Ordinal) &&
            !method.Name.StartsWith("remove_", StringComparison.Ordinal))
        {
            return true;
        }
        return false;
    }

    void WriteFunctionDec(StreamWriter file, string name)
    {
        WriteFunctionAttr(file);
        Write(file, "static public int {0}(IntPtr l) {{", name);
        
    }

    void WriteFunctionImpl(StreamWriter file, MethodInfo m, Type t, int overridecount)
    {
        Write(file, "try{");

        if (overridecount == 1) // no override function
        {
            if (!m.ReturnType.ContainsGenericParameters && !m.ContainsGenericParameters) // don't support generic method
                WriteFunctionCall(m, file, t);
            else
            {
                Write(file, "LuaDLL.luaL_error(l,\"No matched override function to call\");");
                Write(file, "return 0;");
            }
        }
        else // 2 or more override function
        {
            MemberInfo[] cons = t.GetMember(m.Name);
            bool first = true;
            for (int n = 0; n < cons.Length; n++)
            {
                if (cons[n].MemberType == MemberTypes.Method)
                {
                    MethodInfo mi = cons[n] as MethodInfo;
                    ParameterInfo[] pars = mi.GetParameters();
                    if (!mi.ReturnType.ContainsGenericParameters && !containGeneric(pars)) // don't support generic method
                    {

                        Write(file, "{0}(matchType(l,{1}{2})){{", first ? "if" : "else if", mi.IsStatic ? 1 : 2, TypeDecl(pars));
                        WriteFunctionCall(mi, file, t);
                        Write(file, "}");
                        first = false;
                    }
                }
            }
            Write(file, "LuaDLL.luaL_error(l,\"No matched override function to call\");");
            Write(file, "return 0;");
        }
        Write(file, "}");
        Write(file, "catch(Exception e) {");
        Write(file, "LuaDLL.luaL_error(l, e.ToString());");
        Write(file, "return 0;");
        Write(file, "}");
        Write(file, "}");
    }

    bool containGeneric(ParameterInfo[] pars)
    {
        foreach (ParameterInfo p in pars)
        {
            if (p.ParameterType.IsGenericType || p.ParameterType.IsGenericParameter || p.ParameterType.IsGenericTypeDefinition)
                return true;
        }
        return false;
    }

    private void WriteFunctionCall(MethodInfo m, StreamWriter file, Type t)
    {


        bool hasref = false;
        ParameterInfo[] pars = m.GetParameters();

        int argIndex = 1;
        if (!m.IsStatic)
        {
            Write(file, "{0} self=checkSelf<{0}>(l);", FullName(t));
            argIndex++;
        }

        for (int n=0; n < pars.Length; n++)
        {
            ParameterInfo p = pars[n];
            string pn = p.ParameterType.Name;
            if (pn.EndsWith("&"))
            {
                hasref = true;
            }
            CheckArgument(file, p.ParameterType, n, argIndex, p.IsOut);
        }

        string ret = "";
        if (m.ReturnType != typeof(void))
        {
            ret = string.Format("{0} ret=", TypeDecl(m.ReturnType));
        }

        if (m.IsStatic)
        {
            if (m.Name == "op_Multiply")
                Write(file, "{0}a1*a2;", ret);
            else if (m.Name == "op_Subtraction")
                Write(file, "{0}a1-a2;", ret);
            else if (m.Name == "op_Addition")
                Write(file, "{0}a1+a2;", ret);
            else if (m.Name == "op_Division")
                Write(file, "{0}a1/a2;", ret);
            else if (m.Name == "op_UnaryNegation")
                Write(file, "{0}-a1;", ret);
            else if (m.Name == "op_Equality")
                Write(file, "{0}(a1==a2);", ret);
            else if (m.Name == "op_Inequality")
                Write(file, "{0}(a1!=a2);", ret);
            else
                Write(file, "{3}{2}.{0}({1});", m.Name, FuncCall(m), t.FullName, ret);
        }
        else
            Write(file, "{2}self.{0}({1});", m.Name, FuncCall(m), ret);


        int retcount = 0;
        if (m.ReturnType != typeof(void))
        {

            WritePushValue(m.ReturnType, file);
            retcount = 1;
        }


        // push out/ref value for return value
        if (hasref)
        {
            for (int n = 0; n < pars.Length; n++)
            {
                ParameterInfo p = pars[n];

                if (p.ParameterType.IsByRef)
                {
                    WritePushValue(p.ParameterType, file, string.Format("a{0}", n + 1));
                    retcount++;
                }
            }
        }

        if (t.IsValueType && m.ReturnType == typeof(void) && !m.IsStatic)
            Write(file, "setBack(l,self);");

        Write(file, "return {0};", retcount);


        
    }

    bool IsSimpleType(Type t)
    {

        string tn = RemoveRef(t.Name);

        switch (tn)
        {
            case "Single":
            case "Double":
            case "String":
            case "Boolean":
            case "Int32":
            case "UInt32":
            case "Int16":
            case "UInt16":
            case "Int64":
            case "UInt64":
            case "Void":
            case "IntPtr":
            case "SByte":
            case "Byte":
            case "Char":
            case "Type":
            case "Array":
                return true;
            case "Object":
                return t.FullName == "System.Object" || t.FullName == "System.Object[]";
            default:
                if (t.IsEnum)
                    return true;
                return false;
        }
    }

    void WritePushValue(Type t, StreamWriter file)
    {
        Write(file, "pushValue(l,ret);");
    }

    void WritePushValue(Type t, StreamWriter file, string ret)
    {
        Write(file, "pushValue(l,{0});", ret);
    }


    void Write(StreamWriter file, string fmt, params object[] args)
    {
        if (fmt.EndsWith("}")) indent--;

        for (int n = 0; n < indent; n++)
            file.Write("\t");


        if (args.Length == 0)
            file.WriteLine(fmt);
        else
        {
            string line = string.Format(fmt, args);
            file.WriteLine(line);
        }

        if (fmt.EndsWith("{")) indent++;
    }

    private void CheckArgument(StreamWriter file, Type t, int n,int argstart, bool isout)
    {
        Write(file, "{0} a{1};", TypeDecl(t), n + 1);

        if (!isout)
            Write(file, "checkType(l,{0},out a{1});",n+argstart, n + 1);
    }

    string FullName(string str)
    {
        if (str == null)
        {
            throw new NullReferenceException();
        }
        return RemoveRef(str.Replace("+", "."));
    }

    string TypeName(Type t)
    {
        return RemoveRef(t.FullName, false);
    }

    string TypeDecl(Type t)
    {
        return RemoveRef(t.ToString(), false);
    }

    string ExportName(Type t)
    {
        string name = RemoveRef(t.FullName, true);
        name = "Lua_" + name;
        return name.Replace(".", "_");
    }

    string FullName(Type t)
    {
        if (t.FullName == null)
        {
            Debug.Log(t.Name);
            return t.Name;
        }
        return FullName(t.FullName);
    }

    string FuncCall(MethodBase m)
    {

        string str = "";
        ParameterInfo[] pars = m.GetParameters();
        for (int n = 0; n < pars.Length; n++)
        {
            ParameterInfo p = pars[n];
            if (p.ParameterType.IsByRef && p.IsOut)
                str += string.Format("out a{0}", n + 1);
            else if (p.ParameterType.IsByRef)
                str += string.Format("ref a{0}", n + 1);
            else
                str += string.Format("a{0}", n + 1);
            if (n < pars.Length - 1)
                str += ",";
        }
        return str;
    }

}
