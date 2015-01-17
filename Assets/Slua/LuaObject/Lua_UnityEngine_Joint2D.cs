﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Joint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Joint2D o;
		if(matchType(l,1)){
			o=new UnityEngine.Joint2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedBody(IntPtr l) {
		UnityEngine.Joint2D o = checkSelf<UnityEngine.Joint2D>(l);
		pushValue(l,o.connectedBody);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedBody(IntPtr l) {
		UnityEngine.Joint2D o = checkSelf<UnityEngine.Joint2D>(l);
		UnityEngine.Rigidbody2D v;
		checkType(l,2,out v);
		o.connectedBody=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collideConnected(IntPtr l) {
		UnityEngine.Joint2D o = checkSelf<UnityEngine.Joint2D>(l);
		pushValue(l,o.collideConnected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collideConnected(IntPtr l) {
		UnityEngine.Joint2D o = checkSelf<UnityEngine.Joint2D>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.collideConnected=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint2D");
		addMember(l,get_connectedBody, "get_connectedBody");
		addMember(l,set_connectedBody, "set_connectedBody");
		addMember(l,get_collideConnected, "get_collideConnected");
		addMember(l,set_collideConnected, "set_collideConnected");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Joint2D),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
