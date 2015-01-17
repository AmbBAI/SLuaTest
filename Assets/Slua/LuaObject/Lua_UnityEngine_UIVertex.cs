using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UIVertex : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.position);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.position=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Color32 v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uv(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		pushValue(l,o.uv);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uv(IntPtr l) {
		UnityEngine.UIVertex o = checkSelf<UnityEngine.UIVertex>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.uv=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UIVertex");
		addMember(l,get_position, "get_position");
		addMember(l,set_position, "set_position");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_uv, "get_uv");
		addMember(l,set_uv, "set_uv");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UIVertex));
		LuaDLL.lua_pop(l, 1);
	}
}
