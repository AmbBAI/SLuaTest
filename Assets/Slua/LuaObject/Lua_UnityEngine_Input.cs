﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Input : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Input o;
		if(matchType(l,1)){
			o=new UnityEngine.Input();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAxis(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Input.GetAxis(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAxisRaw(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Single ret=UnityEngine.Input.GetAxisRaw(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetButton(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetButton(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetButtonDown(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetButtonDown(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetButtonUp(IntPtr l) {
		try{
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetButtonUp(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKey(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKey(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.KeyCode))){
				UnityEngine.KeyCode a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKey(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKeyDown(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyDown(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.KeyCode))){
				UnityEngine.KeyCode a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyDown(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKeyUp(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.String))){
				System.String a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyUp(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.KeyCode))){
				UnityEngine.KeyCode a1;
				checkType(l,1,out a1);
				System.Boolean ret=UnityEngine.Input.GetKeyUp(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetJoystickNames(IntPtr l) {
		try{
			System.String[] ret=UnityEngine.Input.GetJoystickNames();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouseButton(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetMouseButton(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouseButtonDown(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetMouseButtonDown(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMouseButtonUp(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean ret=UnityEngine.Input.GetMouseButtonUp(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetInputAxes(IntPtr l) {
		try{
			UnityEngine.Input.ResetInputAxes();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAccelerationEvent(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.AccelerationEvent ret=UnityEngine.Input.GetAccelerationEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTouch(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Touch ret=UnityEngine.Input.GetTouch(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compensateSensors(IntPtr l) {
		pushValue(l,UnityEngine.Input.compensateSensors);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_compensateSensors(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Input.compensateSensors=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gyro(IntPtr l) {
		pushValue(l,UnityEngine.Input.gyro);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePosition(IntPtr l) {
		pushValue(l,UnityEngine.Input.mousePosition);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePresent(IntPtr l) {
		pushValue(l,UnityEngine.Input.mousePresent);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulateMouseWithTouches(IntPtr l) {
		pushValue(l,UnityEngine.Input.simulateMouseWithTouches);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulateMouseWithTouches(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Input.simulateMouseWithTouches=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anyKey(IntPtr l) {
		pushValue(l,UnityEngine.Input.anyKey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anyKeyDown(IntPtr l) {
		pushValue(l,UnityEngine.Input.anyKeyDown);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputString(IntPtr l) {
		pushValue(l,UnityEngine.Input.inputString);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		pushValue(l,UnityEngine.Input.acceleration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_accelerationEvents(IntPtr l) {
		pushValue(l,UnityEngine.Input.accelerationEvents);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_accelerationEventCount(IntPtr l) {
		pushValue(l,UnityEngine.Input.accelerationEventCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touches(IntPtr l) {
		pushValue(l,UnityEngine.Input.touches);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_touchCount(IntPtr l) {
		pushValue(l,UnityEngine.Input.touchCount);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_multiTouchEnabled(IntPtr l) {
		pushValue(l,UnityEngine.Input.multiTouchEnabled);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_multiTouchEnabled(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Input.multiTouchEnabled=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_location(IntPtr l) {
		pushValue(l,UnityEngine.Input.location);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compass(IntPtr l) {
		pushValue(l,UnityEngine.Input.compass);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deviceOrientation(IntPtr l) {
		pushValue(l,UnityEngine.Input.deviceOrientation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imeCompositionMode(IntPtr l) {
		pushValue(l,UnityEngine.Input.imeCompositionMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_imeCompositionMode(IntPtr l) {
		UnityEngine.IMECompositionMode v;
		checkType(l,2,out v);
		UnityEngine.Input.imeCompositionMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compositionString(IntPtr l) {
		pushValue(l,UnityEngine.Input.compositionString);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_imeIsSelected(IntPtr l) {
		pushValue(l,UnityEngine.Input.imeIsSelected);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_compositionCursorPos(IntPtr l) {
		pushValue(l,UnityEngine.Input.compositionCursorPos);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_compositionCursorPos(IntPtr l) {
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		UnityEngine.Input.compositionCursorPos=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Input");
		addMember(l,GetAxis, "GetAxis");
		addMember(l,GetAxisRaw, "GetAxisRaw");
		addMember(l,GetButton, "GetButton");
		addMember(l,GetButtonDown, "GetButtonDown");
		addMember(l,GetButtonUp, "GetButtonUp");
		addMember(l,GetKey, "GetKey");
		addMember(l,GetKeyDown, "GetKeyDown");
		addMember(l,GetKeyUp, "GetKeyUp");
		addMember(l,GetJoystickNames, "GetJoystickNames");
		addMember(l,GetMouseButton, "GetMouseButton");
		addMember(l,GetMouseButtonDown, "GetMouseButtonDown");
		addMember(l,GetMouseButtonUp, "GetMouseButtonUp");
		addMember(l,ResetInputAxes, "ResetInputAxes");
		addMember(l,GetAccelerationEvent, "GetAccelerationEvent");
		addMember(l,GetTouch, "GetTouch");
		addMember(l,get_compensateSensors, "get_compensateSensors");
		addMember(l,set_compensateSensors, "set_compensateSensors");
		addMember(l,get_gyro, "get_gyro");
		addMember(l,get_mousePosition, "get_mousePosition");
		addMember(l,get_mousePresent, "get_mousePresent");
		addMember(l,get_simulateMouseWithTouches, "get_simulateMouseWithTouches");
		addMember(l,set_simulateMouseWithTouches, "set_simulateMouseWithTouches");
		addMember(l,get_anyKey, "get_anyKey");
		addMember(l,get_anyKeyDown, "get_anyKeyDown");
		addMember(l,get_inputString, "get_inputString");
		addMember(l,get_acceleration, "get_acceleration");
		addMember(l,get_accelerationEvents, "get_accelerationEvents");
		addMember(l,get_accelerationEventCount, "get_accelerationEventCount");
		addMember(l,get_touches, "get_touches");
		addMember(l,get_touchCount, "get_touchCount");
		addMember(l,get_multiTouchEnabled, "get_multiTouchEnabled");
		addMember(l,set_multiTouchEnabled, "set_multiTouchEnabled");
		addMember(l,get_location, "get_location");
		addMember(l,get_compass, "get_compass");
		addMember(l,get_deviceOrientation, "get_deviceOrientation");
		addMember(l,get_imeCompositionMode, "get_imeCompositionMode");
		addMember(l,set_imeCompositionMode, "set_imeCompositionMode");
		addMember(l,get_compositionString, "get_compositionString");
		addMember(l,get_imeIsSelected, "get_imeIsSelected");
		addMember(l,get_compositionCursorPos, "get_compositionCursorPos");
		addMember(l,set_compositionCursorPos, "set_compositionCursorPos");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Input));
		LuaDLL.lua_pop(l, 1);
	}
}
