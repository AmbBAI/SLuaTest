﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Sprite : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Sprite o;
		if(matchType(l,1)){
			o=new UnityEngine.Sprite();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Create(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.UInt32),typeof(UnityEngine.SpriteMeshType),typeof(UnityEngine.Vector4))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.SpriteMeshType a6;
				checkType(l,6,out a6);
				UnityEngine.Vector4 a7;
				checkType(l,7,out a7);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.UInt32),typeof(UnityEngine.SpriteMeshType))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.SpriteMeshType a6;
				checkType(l,6,out a6);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.UInt32))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.UInt32 a5;
				checkType(l,5,out a5);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Texture2D),typeof(UnityEngine.Rect),typeof(UnityEngine.Vector2))){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Rect a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.Sprite ret=UnityEngine.Sprite.Create(a1,a2,a3);
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
	static public int get_bounds(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.bounds);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rect(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.rect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.texture);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRect(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.textureRect);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textureRectOffset(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.textureRectOffset);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packed(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.packed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packingMode(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.packingMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_packingRotation(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.packingRotation);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_border(IntPtr l) {
		UnityEngine.Sprite o = checkSelf<UnityEngine.Sprite>(l);
		pushValue(l,o.border);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Sprite");
		addMember(l,Create, "Create");
		addMember(l,get_bounds, "get_bounds");
		addMember(l,get_rect, "get_rect");
		addMember(l,get_texture, "get_texture");
		addMember(l,get_textureRect, "get_textureRect");
		addMember(l,get_textureRectOffset, "get_textureRectOffset");
		addMember(l,get_packed, "get_packed");
		addMember(l,get_packingMode, "get_packingMode");
		addMember(l,get_packingRotation, "get_packingRotation");
		addMember(l,get_border, "get_border");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Sprite),typeof(UnityEngine.Object));
		LuaDLL.lua_pop(l, 1);
	}
}
