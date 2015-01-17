﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Physics2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Physics2D o;
		if(matchType(l,1)){
			o=new UnityEngine.Physics2D();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreCollision(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Collider2D),typeof(UnityEngine.Collider2D),typeof(System.Boolean))){
				UnityEngine.Collider2D a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics2D.IgnoreCollision(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.Collider2D),typeof(UnityEngine.Collider2D))){
				UnityEngine.Collider2D a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D a2;
				checkType(l,2,out a2);
				UnityEngine.Physics2D.IgnoreCollision(a1,a2);
				return 0;
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
	static public int GetIgnoreCollision(IntPtr l) {
		try{
			UnityEngine.Collider2D a1;
			checkType(l,1,out a1);
			UnityEngine.Collider2D a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Physics2D.GetIgnoreCollision(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IgnoreLayerCollision(IntPtr l) {
		try{
			if(matchType(l,1,typeof(System.Int32),typeof(System.Int32),typeof(System.Boolean))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				UnityEngine.Physics2D.IgnoreLayerCollision(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,1,typeof(System.Int32),typeof(System.Int32))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Physics2D.IgnoreLayerCollision(a1,a2);
				return 0;
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
	static public int GetIgnoreLayerCollision(IntPtr l) {
		try{
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean ret=UnityEngine.Physics2D.GetIgnoreLayerCollision(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Linecast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Linecast(a1,a2,a3,a4,a5);
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
	static public int LinecastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.LinecastAll(a1,a2);
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
	static public int LinecastNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.LinecastNonAlloc(a1,a2,a3);
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
	static public int Raycast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.Raycast(a1,a2,a3,a4,a5,a6);
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
	static public int RaycastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.RaycastAll(a1,a2);
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
	static public int RaycastNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.RaycastNonAlloc(a1,a2,a3);
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
	static public int CircleCast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.CircleCast(a1,a2,a3,a4,a5,a6,a7);
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
	static public int CircleCastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.CircleCastAll(a1,a2,a3);
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
	static public int CircleCastNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Vector2 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.CircleCastNonAlloc(a1,a2,a3,a4);
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
	static public int BoxCast(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.BoxCast(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int BoxCastAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				System.Single a7;
				checkType(l,7,out a7);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 a6;
				checkType(l,6,out a6);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.BoxCastAll(a1,a2,a3,a4);
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
	static public int BoxCastNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				System.Single a9;
				checkType(l,9,out a9);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Single a8;
				checkType(l,8,out a8);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 a7;
				checkType(l,7,out a7);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Vector2),typeof(UnityEngine.RaycastHit2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Vector2 a4;
				checkType(l,4,out a4);
				UnityEngine.RaycastHit2D[] a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.BoxCastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int GetRayIntersection(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.GetRayIntersection(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.GetRayIntersection(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D ret=UnityEngine.Physics2D.GetRayIntersection(a1,a2,a3);
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
	static public int GetRayIntersectionAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.GetRayIntersectionAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.GetRayIntersectionAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] ret=UnityEngine.Physics2D.GetRayIntersectionAll(a1);
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
	static public int GetRayIntersectionNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit2D),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.GetRayIntersectionNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit2D),typeof(System.Single))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.GetRayIntersectionNonAlloc(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Ray),typeof(UnityEngine.RaycastHit2D))){
				UnityEngine.Ray a1;
				checkType(l,1,out a1);
				UnityEngine.RaycastHit2D[] a2;
				checkType(l,2,out a2);
				System.Int32 ret=UnityEngine.Physics2D.GetRayIntersectionNonAlloc(a1,a2);
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
	static public int OverlapPoint(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapPoint(a1);
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
	static public int OverlapPointAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapPointAll(a1);
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
	static public int OverlapPointNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Collider2D[] a2;
				checkType(l,2,out a2);
				System.Int32 ret=UnityEngine.Physics2D.OverlapPointNonAlloc(a1,a2);
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
	static public int OverlapCircle(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapCircle(a1,a2);
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
	static public int OverlapCircleAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapCircleAll(a1,a2);
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
	static public int OverlapCircleNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Collider2D),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Collider2D),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Collider2D),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(System.Single),typeof(UnityEngine.Collider2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.OverlapCircleNonAlloc(a1,a2,a3);
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
	static public int OverlapArea(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D ret=UnityEngine.Physics2D.OverlapArea(a1,a2);
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
	static public int OverlapAreaAll(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] ret=UnityEngine.Physics2D.OverlapAreaAll(a1,a2);
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
	static public int OverlapAreaNonAlloc(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D),typeof(System.Int32),typeof(System.Single),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Single a6;
				checkType(l,6,out a6);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3,a4,a5,a6);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D),typeof(System.Int32),typeof(System.Single))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Single a5;
				checkType(l,5,out a5);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3,a4,a5);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D),typeof(System.Int32))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3,a4);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Vector2),typeof(UnityEngine.Vector2),typeof(UnityEngine.Collider2D))){
				UnityEngine.Vector2 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,2,out a2);
				UnityEngine.Collider2D[] a3;
				checkType(l,3,out a3);
				System.Int32 ret=UnityEngine.Physics2D.OverlapAreaNonAlloc(a1,a2,a3);
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
	static public int get_IgnoreRaycastLayer(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.IgnoreRaycastLayer);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DefaultRaycastLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.DefaultRaycastLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AllLayers(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.AllLayers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityIterations(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.velocityIterations);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityIterations(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.velocityIterations=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_positionIterations(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.positionIterations);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_positionIterations(IntPtr l) {
		System.Int32 v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.positionIterations=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravity(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.gravity);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravity(IntPtr l) {
		UnityEngine.Vector2 v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.gravity=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_raycastsHitTriggers(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.raycastsHitTriggers);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_raycastsHitTriggers(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.raycastsHitTriggers=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deleteStopsCallbacks(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.deleteStopsCallbacks);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_deleteStopsCallbacks(IntPtr l) {
		System.Boolean v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.deleteStopsCallbacks=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityThreshold(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.velocityThreshold);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityThreshold(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.velocityThreshold=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxLinearCorrection(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxLinearCorrection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxLinearCorrection(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxLinearCorrection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxAngularCorrection(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxAngularCorrection);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxAngularCorrection(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxAngularCorrection=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxTranslationSpeed(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxTranslationSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxTranslationSpeed(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxTranslationSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxRotationSpeed(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.maxRotationSpeed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxRotationSpeed(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.maxRotationSpeed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baumgarteScale(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.baumgarteScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baumgarteScale(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.baumgarteScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baumgarteTOIScale(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.baumgarteTOIScale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baumgarteTOIScale(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.baumgarteTOIScale=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeToSleep(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.timeToSleep);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeToSleep(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.timeToSleep=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linearSleepTolerance(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.linearSleepTolerance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_linearSleepTolerance(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.linearSleepTolerance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularSleepTolerance(IntPtr l) {
		pushValue(l,UnityEngine.Physics2D.angularSleepTolerance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularSleepTolerance(IntPtr l) {
		System.Single v;
		checkType(l,2,out v);
		UnityEngine.Physics2D.angularSleepTolerance=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Physics2D");
		addMember(l,IgnoreCollision, "IgnoreCollision");
		addMember(l,GetIgnoreCollision, "GetIgnoreCollision");
		addMember(l,IgnoreLayerCollision, "IgnoreLayerCollision");
		addMember(l,GetIgnoreLayerCollision, "GetIgnoreLayerCollision");
		addMember(l,Linecast, "Linecast");
		addMember(l,LinecastAll, "LinecastAll");
		addMember(l,LinecastNonAlloc, "LinecastNonAlloc");
		addMember(l,Raycast, "Raycast");
		addMember(l,RaycastAll, "RaycastAll");
		addMember(l,RaycastNonAlloc, "RaycastNonAlloc");
		addMember(l,CircleCast, "CircleCast");
		addMember(l,CircleCastAll, "CircleCastAll");
		addMember(l,CircleCastNonAlloc, "CircleCastNonAlloc");
		addMember(l,BoxCast, "BoxCast");
		addMember(l,BoxCastAll, "BoxCastAll");
		addMember(l,BoxCastNonAlloc, "BoxCastNonAlloc");
		addMember(l,GetRayIntersection, "GetRayIntersection");
		addMember(l,GetRayIntersectionAll, "GetRayIntersectionAll");
		addMember(l,GetRayIntersectionNonAlloc, "GetRayIntersectionNonAlloc");
		addMember(l,OverlapPoint, "OverlapPoint");
		addMember(l,OverlapPointAll, "OverlapPointAll");
		addMember(l,OverlapPointNonAlloc, "OverlapPointNonAlloc");
		addMember(l,OverlapCircle, "OverlapCircle");
		addMember(l,OverlapCircleAll, "OverlapCircleAll");
		addMember(l,OverlapCircleNonAlloc, "OverlapCircleNonAlloc");
		addMember(l,OverlapArea, "OverlapArea");
		addMember(l,OverlapAreaAll, "OverlapAreaAll");
		addMember(l,OverlapAreaNonAlloc, "OverlapAreaNonAlloc");
		addMember(l,get_IgnoreRaycastLayer, "get_IgnoreRaycastLayer");
		addMember(l,get_DefaultRaycastLayers, "get_DefaultRaycastLayers");
		addMember(l,get_AllLayers, "get_AllLayers");
		addMember(l,get_velocityIterations, "get_velocityIterations");
		addMember(l,set_velocityIterations, "set_velocityIterations");
		addMember(l,get_positionIterations, "get_positionIterations");
		addMember(l,set_positionIterations, "set_positionIterations");
		addMember(l,get_gravity, "get_gravity");
		addMember(l,set_gravity, "set_gravity");
		addMember(l,get_raycastsHitTriggers, "get_raycastsHitTriggers");
		addMember(l,set_raycastsHitTriggers, "set_raycastsHitTriggers");
		addMember(l,get_deleteStopsCallbacks, "get_deleteStopsCallbacks");
		addMember(l,set_deleteStopsCallbacks, "set_deleteStopsCallbacks");
		addMember(l,get_velocityThreshold, "get_velocityThreshold");
		addMember(l,set_velocityThreshold, "set_velocityThreshold");
		addMember(l,get_maxLinearCorrection, "get_maxLinearCorrection");
		addMember(l,set_maxLinearCorrection, "set_maxLinearCorrection");
		addMember(l,get_maxAngularCorrection, "get_maxAngularCorrection");
		addMember(l,set_maxAngularCorrection, "set_maxAngularCorrection");
		addMember(l,get_maxTranslationSpeed, "get_maxTranslationSpeed");
		addMember(l,set_maxTranslationSpeed, "set_maxTranslationSpeed");
		addMember(l,get_maxRotationSpeed, "get_maxRotationSpeed");
		addMember(l,set_maxRotationSpeed, "set_maxRotationSpeed");
		addMember(l,get_baumgarteScale, "get_baumgarteScale");
		addMember(l,set_baumgarteScale, "set_baumgarteScale");
		addMember(l,get_baumgarteTOIScale, "get_baumgarteTOIScale");
		addMember(l,set_baumgarteTOIScale, "set_baumgarteTOIScale");
		addMember(l,get_timeToSleep, "get_timeToSleep");
		addMember(l,set_timeToSleep, "set_timeToSleep");
		addMember(l,get_linearSleepTolerance, "get_linearSleepTolerance");
		addMember(l,set_linearSleepTolerance, "set_linearSleepTolerance");
		addMember(l,get_angularSleepTolerance, "get_angularSleepTolerance");
		addMember(l,set_angularSleepTolerance, "set_angularSleepTolerance");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Physics2D));
		LuaDLL.lua_pop(l, 1);
	}
}
