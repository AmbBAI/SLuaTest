﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioSource : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AudioSource o;
		if(matchType(l,1)){
			o=new UnityEngine.AudioSource();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.UInt64))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				System.UInt64 a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(matchType(l,2)){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				self.Play();
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
	static public int PlayDelayed(IntPtr l) {
		try{
			UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.PlayDelayed(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayScheduled(IntPtr l) {
		try{
			UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.PlayScheduled(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetScheduledStartTime(IntPtr l) {
		try{
			UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.SetScheduledStartTime(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetScheduledEndTime(IntPtr l) {
		try{
			UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.SetScheduledEndTime(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try{
			UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
			self.Stop();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Pause(IntPtr l) {
		try{
			UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
			self.Pause();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PlayOneShot(IntPtr l) {
		try{
			if(matchType(l,2,typeof(UnityEngine.AudioClip),typeof(System.Single))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.PlayOneShot(a1,a2);
				return 0;
			}
			else if(matchType(l,2,typeof(UnityEngine.AudioClip))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				UnityEngine.AudioClip a1;
				checkType(l,2,out a1);
				self.PlayOneShot(a1);
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
	static public int PlayClipAtPoint(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.AudioClip),typeof(UnityEngine.Vector3))){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.AudioSource.PlayClipAtPoint(a1,a2);
				return 0;
			}
			else if(matchType(l,1,typeof(UnityEngine.AudioClip),typeof(UnityEngine.Vector3),typeof(System.Single))){
				UnityEngine.AudioClip a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				System.Single a3;
				checkType(l,3,out a3);
				UnityEngine.AudioSource.PlayClipAtPoint(a1,a2,a3);
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
	static public int GetOutputData(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32),typeof(System.Int32))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single[] ret=self.GetOutputData(a1,a2);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Int32))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				System.Single[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.GetOutputData(a1,a2);
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
	static public int GetSpectrumData(IntPtr l) {
		try{
			if(matchType(l,2,typeof(System.Int32),typeof(System.Int32),typeof(UnityEngine.FFTWindow))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.FFTWindow a3;
				checkType(l,4,out a3);
				System.Single[] ret=self.GetSpectrumData(a1,a2,a3);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,2,typeof(System.Single),typeof(System.Int32),typeof(UnityEngine.FFTWindow))){
				UnityEngine.AudioSource self=checkSelf<UnityEngine.AudioSource>(l);
				System.Single[] a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.FFTWindow a3;
				checkType(l,4,out a3);
				self.GetSpectrumData(a1,a2,a3);
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
	static public int get_volume(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.volume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_volume(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.volume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pitch(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.pitch);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pitch(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.pitch=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.time);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.time=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeSamples(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.timeSamples);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeSamples(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.timeSamples=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.clip);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clip(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		UnityEngine.AudioClip v;
		checkType(l,2,out v);
		o.clip=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPlaying(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.isPlaying);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loop(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.loop);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.loop=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreListenerVolume(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.ignoreListenerVolume);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreListenerVolume(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreListenerVolume=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playOnAwake(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.playOnAwake);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playOnAwake(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.playOnAwake=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ignoreListenerPause(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.ignoreListenerPause);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ignoreListenerPause(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.ignoreListenerPause=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.velocityUpdateMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityUpdateMode(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		UnityEngine.AudioVelocityUpdateMode v;
		checkType(l,2,out v);
		o.velocityUpdateMode=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_panLevel(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.panLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_panLevel(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.panLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bypassEffects(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.bypassEffects);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bypassEffects(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.bypassEffects=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bypassListenerEffects(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.bypassListenerEffects);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bypassListenerEffects(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.bypassListenerEffects=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bypassReverbZones(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.bypassReverbZones);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bypassReverbZones(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.bypassReverbZones=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dopplerLevel(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.dopplerLevel);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dopplerLevel(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.dopplerLevel=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spread(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.spread);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spread(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.spread=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_priority(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.priority);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_priority(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Int32 v;
		checkType(l,2,out v);
		o.priority=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mute(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.mute);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mute(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Boolean v;
		checkType(l,2,out v);
		o.mute=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minDistance(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.minDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minDistance(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.minDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.maxDistance);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.maxDistance=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pan(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.pan);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pan(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		System.Single v;
		checkType(l,2,out v);
		o.pan=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rolloffMode(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		pushValue(l,o.rolloffMode);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rolloffMode(IntPtr l) {
		UnityEngine.AudioSource o = checkSelf<UnityEngine.AudioSource>(l);
		UnityEngine.AudioRolloffMode v;
		checkType(l,2,out v);
		o.rolloffMode=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioSource");
		addMember(l,Play, "Play");
		addMember(l,PlayDelayed, "PlayDelayed");
		addMember(l,PlayScheduled, "PlayScheduled");
		addMember(l,SetScheduledStartTime, "SetScheduledStartTime");
		addMember(l,SetScheduledEndTime, "SetScheduledEndTime");
		addMember(l,Stop, "Stop");
		addMember(l,Pause, "Pause");
		addMember(l,PlayOneShot, "PlayOneShot");
		addMember(l,PlayClipAtPoint, "PlayClipAtPoint");
		addMember(l,GetOutputData, "GetOutputData");
		addMember(l,GetSpectrumData, "GetSpectrumData");
		addMember(l,get_volume, "get_volume");
		addMember(l,set_volume, "set_volume");
		addMember(l,get_pitch, "get_pitch");
		addMember(l,set_pitch, "set_pitch");
		addMember(l,get_time, "get_time");
		addMember(l,set_time, "set_time");
		addMember(l,get_timeSamples, "get_timeSamples");
		addMember(l,set_timeSamples, "set_timeSamples");
		addMember(l,get_clip, "get_clip");
		addMember(l,set_clip, "set_clip");
		addMember(l,get_isPlaying, "get_isPlaying");
		addMember(l,get_loop, "get_loop");
		addMember(l,set_loop, "set_loop");
		addMember(l,get_ignoreListenerVolume, "get_ignoreListenerVolume");
		addMember(l,set_ignoreListenerVolume, "set_ignoreListenerVolume");
		addMember(l,get_playOnAwake, "get_playOnAwake");
		addMember(l,set_playOnAwake, "set_playOnAwake");
		addMember(l,get_ignoreListenerPause, "get_ignoreListenerPause");
		addMember(l,set_ignoreListenerPause, "set_ignoreListenerPause");
		addMember(l,get_velocityUpdateMode, "get_velocityUpdateMode");
		addMember(l,set_velocityUpdateMode, "set_velocityUpdateMode");
		addMember(l,get_panLevel, "get_panLevel");
		addMember(l,set_panLevel, "set_panLevel");
		addMember(l,get_bypassEffects, "get_bypassEffects");
		addMember(l,set_bypassEffects, "set_bypassEffects");
		addMember(l,get_bypassListenerEffects, "get_bypassListenerEffects");
		addMember(l,set_bypassListenerEffects, "set_bypassListenerEffects");
		addMember(l,get_bypassReverbZones, "get_bypassReverbZones");
		addMember(l,set_bypassReverbZones, "set_bypassReverbZones");
		addMember(l,get_dopplerLevel, "get_dopplerLevel");
		addMember(l,set_dopplerLevel, "set_dopplerLevel");
		addMember(l,get_spread, "get_spread");
		addMember(l,set_spread, "set_spread");
		addMember(l,get_priority, "get_priority");
		addMember(l,set_priority, "set_priority");
		addMember(l,get_mute, "get_mute");
		addMember(l,set_mute, "set_mute");
		addMember(l,get_minDistance, "get_minDistance");
		addMember(l,set_minDistance, "set_minDistance");
		addMember(l,get_maxDistance, "get_maxDistance");
		addMember(l,set_maxDistance, "set_maxDistance");
		addMember(l,get_pan, "get_pan");
		addMember(l,set_pan, "set_pan");
		addMember(l,get_rolloffMode, "get_rolloffMode");
		addMember(l,set_rolloffMode, "set_rolloffMode");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AudioSource),typeof(UnityEngine.Behaviour));
		LuaDLL.lua_pop(l, 1);
	}
}
