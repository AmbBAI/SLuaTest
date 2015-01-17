﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SystemLanguage : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.SystemLanguage o = (UnityEngine.SystemLanguage)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SystemLanguage");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "Afrikaans");
		LuaDLL.lua_pushinteger(l, 1);
		LuaDLL.lua_setfield(l, -2, "Arabic");
		LuaDLL.lua_pushinteger(l, 2);
		LuaDLL.lua_setfield(l, -2, "Basque");
		LuaDLL.lua_pushinteger(l, 3);
		LuaDLL.lua_setfield(l, -2, "Belarusian");
		LuaDLL.lua_pushinteger(l, 4);
		LuaDLL.lua_setfield(l, -2, "Bulgarian");
		LuaDLL.lua_pushinteger(l, 5);
		LuaDLL.lua_setfield(l, -2, "Catalan");
		LuaDLL.lua_pushinteger(l, 6);
		LuaDLL.lua_setfield(l, -2, "Chinese");
		LuaDLL.lua_pushinteger(l, 7);
		LuaDLL.lua_setfield(l, -2, "Czech");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "Danish");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "Dutch");
		LuaDLL.lua_pushinteger(l, 10);
		LuaDLL.lua_setfield(l, -2, "English");
		LuaDLL.lua_pushinteger(l, 11);
		LuaDLL.lua_setfield(l, -2, "Estonian");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "Faroese");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "Finnish");
		LuaDLL.lua_pushinteger(l, 14);
		LuaDLL.lua_setfield(l, -2, "French");
		LuaDLL.lua_pushinteger(l, 15);
		LuaDLL.lua_setfield(l, -2, "German");
		LuaDLL.lua_pushinteger(l, 16);
		LuaDLL.lua_setfield(l, -2, "Greek");
		LuaDLL.lua_pushinteger(l, 17);
		LuaDLL.lua_setfield(l, -2, "Hebrew");
		LuaDLL.lua_pushinteger(l, 18);
		LuaDLL.lua_setfield(l, -2, "Hugarian");
		LuaDLL.lua_pushinteger(l, 19);
		LuaDLL.lua_setfield(l, -2, "Icelandic");
		LuaDLL.lua_pushinteger(l, 20);
		LuaDLL.lua_setfield(l, -2, "Indonesian");
		LuaDLL.lua_pushinteger(l, 21);
		LuaDLL.lua_setfield(l, -2, "Italian");
		LuaDLL.lua_pushinteger(l, 22);
		LuaDLL.lua_setfield(l, -2, "Japanese");
		LuaDLL.lua_pushinteger(l, 23);
		LuaDLL.lua_setfield(l, -2, "Korean");
		LuaDLL.lua_pushinteger(l, 24);
		LuaDLL.lua_setfield(l, -2, "Latvian");
		LuaDLL.lua_pushinteger(l, 25);
		LuaDLL.lua_setfield(l, -2, "Lithuanian");
		LuaDLL.lua_pushinteger(l, 26);
		LuaDLL.lua_setfield(l, -2, "Norwegian");
		LuaDLL.lua_pushinteger(l, 27);
		LuaDLL.lua_setfield(l, -2, "Polish");
		LuaDLL.lua_pushinteger(l, 28);
		LuaDLL.lua_setfield(l, -2, "Portuguese");
		LuaDLL.lua_pushinteger(l, 29);
		LuaDLL.lua_setfield(l, -2, "Romanian");
		LuaDLL.lua_pushinteger(l, 30);
		LuaDLL.lua_setfield(l, -2, "Russian");
		LuaDLL.lua_pushinteger(l, 31);
		LuaDLL.lua_setfield(l, -2, "SerboCroatian");
		LuaDLL.lua_pushinteger(l, 32);
		LuaDLL.lua_setfield(l, -2, "Slovak");
		LuaDLL.lua_pushinteger(l, 33);
		LuaDLL.lua_setfield(l, -2, "Slovenian");
		LuaDLL.lua_pushinteger(l, 34);
		LuaDLL.lua_setfield(l, -2, "Spanish");
		LuaDLL.lua_pushinteger(l, 35);
		LuaDLL.lua_setfield(l, -2, "Swedish");
		LuaDLL.lua_pushinteger(l, 36);
		LuaDLL.lua_setfield(l, -2, "Thai");
		LuaDLL.lua_pushinteger(l, 37);
		LuaDLL.lua_setfield(l, -2, "Turkish");
		LuaDLL.lua_pushinteger(l, 38);
		LuaDLL.lua_setfield(l, -2, "Ukrainian");
		LuaDLL.lua_pushinteger(l, 39);
		LuaDLL.lua_setfield(l, -2, "Vietnamese");
		LuaDLL.lua_pushinteger(l, 40);
		LuaDLL.lua_setfield(l, -2, "Unknown");
		LuaDLL.lua_pushinteger(l, 18);
		LuaDLL.lua_setfield(l, -2, "Hungarian");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
