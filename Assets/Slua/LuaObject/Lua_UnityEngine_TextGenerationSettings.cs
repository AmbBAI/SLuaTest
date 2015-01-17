using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TextGenerationSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.color);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.Color v;
		checkType(l,2,out v);
		o.color=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.size);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.size=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_style(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.style);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_style(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.FontStyle v;
		checkType(l,2,out v);
		o.style=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_richText(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.richText);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_richText(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.richText=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.anchor);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.TextAnchor v;
		checkType(l,2,out v);
		o.anchor=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wrapMode(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.wrapMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_wrapMode(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.TextWrapMode v;
		checkType(l,2,out v);
		o.wrapMode=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_extents(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.extents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_extents(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.extents=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.pivot);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		o.pivot=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_font(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		pushValue(l,o.font);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_font(IntPtr l) {
		UnityEngine.TextGenerationSettings o = checkSelf<UnityEngine.TextGenerationSettings>(l);
		UnityEngine.Font v;
		checkType(l,2,out v);
		o.font=v;
		setBack(l,o);
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TextGenerationSettings");
		addMember(l,get_color, "get_color");
		addMember(l,set_color, "set_color");
		addMember(l,get_size, "get_size");
		addMember(l,set_size, "set_size");
		addMember(l,get_style, "get_style");
		addMember(l,set_style, "set_style");
		addMember(l,get_richText, "get_richText");
		addMember(l,set_richText, "set_richText");
		addMember(l,get_anchor, "get_anchor");
		addMember(l,set_anchor, "set_anchor");
		addMember(l,get_wrapMode, "get_wrapMode");
		addMember(l,set_wrapMode, "set_wrapMode");
		addMember(l,get_extents, "get_extents");
		addMember(l,set_extents, "set_extents");
		addMember(l,get_pivot, "get_pivot");
		addMember(l,set_pivot, "set_pivot");
		addMember(l,get_font, "get_font");
		addMember(l,set_font, "set_font");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.TextGenerationSettings));
		LuaDLL.lua_pop(l, 1);
	}
}
