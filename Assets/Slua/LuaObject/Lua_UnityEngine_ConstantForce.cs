﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ConstantForce : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.ConstantForce o;
		if(matchType(l,1)){
			o=new UnityEngine.ConstantForce();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		pushValue(l,o.force);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.force=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeForce(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		pushValue(l,o.relativeForce);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeForce(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.relativeForce=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_torque(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		pushValue(l,o.torque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_torque(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.torque=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeTorque(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		pushValue(l,o.relativeTorque);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_relativeTorque(IntPtr l) {
		UnityEngine.ConstantForce o = checkSelf<UnityEngine.ConstantForce>(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.relativeTorque=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ConstantForce");
		addMember(l,get_force, "get_force");
		addMember(l,set_force, "set_force");
		addMember(l,get_relativeForce, "get_relativeForce");
		addMember(l,set_relativeForce, "set_relativeForce");
		addMember(l,get_torque, "get_torque");
		addMember(l,set_torque, "set_torque");
		addMember(l,get_relativeTorque, "get_relativeTorque");
		addMember(l,set_relativeTorque, "set_relativeTorque");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.ConstantForce),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
