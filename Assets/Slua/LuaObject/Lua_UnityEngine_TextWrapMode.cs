using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextWrapMode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.TextWrapMode o = (UnityEngine.TextWrapMode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextWrapMode");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Wrap");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "ResizeBounds");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "ShrinkText");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "GrowText");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "BestFit");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
