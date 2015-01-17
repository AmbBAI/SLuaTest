﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Ping : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Ping o;
		if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Ping(a1);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DestroyPing(IntPtr l) {
		try{
			UnityEngine.Ping self=checkSelf<UnityEngine.Ping>(l);
			self.DestroyPing();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDone(IntPtr l) {
		UnityEngine.Ping o = checkSelf<UnityEngine.Ping>(l);
		pushValue(l,o.isDone);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.Ping o = checkSelf<UnityEngine.Ping>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ip(IntPtr l) {
		UnityEngine.Ping o = checkSelf<UnityEngine.Ping>(l);
		pushValue(l,o.ip);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Ping");
		addMember(l,DestroyPing, "DestroyPing");
		addMember(l,get_isDone, "get_isDone");
		addMember(l,get_time, "get_time");
		addMember(l,get_ip, "get_ip");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Ping));
		LuaDLL.lua_pop(l, 1);
	}
}
