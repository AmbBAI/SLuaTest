﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_KeyCode : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr l) {
		int v = LuaDLL.lua_tointeger(l, 1);
		UnityEngine.KeyCode o = (UnityEngine.KeyCode)v;
		pushValue(l,o);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.KeyCode");
		LuaDLL.lua_pushinteger(l, 0);
		LuaDLL.lua_setfield(l, -2, "None");
		LuaDLL.lua_pushinteger(l, 8);
		LuaDLL.lua_setfield(l, -2, "Backspace");
		LuaDLL.lua_pushinteger(l, 127);
		LuaDLL.lua_setfield(l, -2, "Delete");
		LuaDLL.lua_pushinteger(l, 9);
		LuaDLL.lua_setfield(l, -2, "Tab");
		LuaDLL.lua_pushinteger(l, 12);
		LuaDLL.lua_setfield(l, -2, "Clear");
		LuaDLL.lua_pushinteger(l, 13);
		LuaDLL.lua_setfield(l, -2, "Return");
		LuaDLL.lua_pushinteger(l, 19);
		LuaDLL.lua_setfield(l, -2, "Pause");
		LuaDLL.lua_pushinteger(l, 27);
		LuaDLL.lua_setfield(l, -2, "Escape");
		LuaDLL.lua_pushinteger(l, 32);
		LuaDLL.lua_setfield(l, -2, "Space");
		LuaDLL.lua_pushinteger(l, 256);
		LuaDLL.lua_setfield(l, -2, "Keypad0");
		LuaDLL.lua_pushinteger(l, 257);
		LuaDLL.lua_setfield(l, -2, "Keypad1");
		LuaDLL.lua_pushinteger(l, 258);
		LuaDLL.lua_setfield(l, -2, "Keypad2");
		LuaDLL.lua_pushinteger(l, 259);
		LuaDLL.lua_setfield(l, -2, "Keypad3");
		LuaDLL.lua_pushinteger(l, 260);
		LuaDLL.lua_setfield(l, -2, "Keypad4");
		LuaDLL.lua_pushinteger(l, 261);
		LuaDLL.lua_setfield(l, -2, "Keypad5");
		LuaDLL.lua_pushinteger(l, 262);
		LuaDLL.lua_setfield(l, -2, "Keypad6");
		LuaDLL.lua_pushinteger(l, 263);
		LuaDLL.lua_setfield(l, -2, "Keypad7");
		LuaDLL.lua_pushinteger(l, 264);
		LuaDLL.lua_setfield(l, -2, "Keypad8");
		LuaDLL.lua_pushinteger(l, 265);
		LuaDLL.lua_setfield(l, -2, "Keypad9");
		LuaDLL.lua_pushinteger(l, 266);
		LuaDLL.lua_setfield(l, -2, "KeypadPeriod");
		LuaDLL.lua_pushinteger(l, 267);
		LuaDLL.lua_setfield(l, -2, "KeypadDivide");
		LuaDLL.lua_pushinteger(l, 268);
		LuaDLL.lua_setfield(l, -2, "KeypadMultiply");
		LuaDLL.lua_pushinteger(l, 269);
		LuaDLL.lua_setfield(l, -2, "KeypadMinus");
		LuaDLL.lua_pushinteger(l, 270);
		LuaDLL.lua_setfield(l, -2, "KeypadPlus");
		LuaDLL.lua_pushinteger(l, 271);
		LuaDLL.lua_setfield(l, -2, "KeypadEnter");
		LuaDLL.lua_pushinteger(l, 272);
		LuaDLL.lua_setfield(l, -2, "KeypadEquals");
		LuaDLL.lua_pushinteger(l, 273);
		LuaDLL.lua_setfield(l, -2, "UpArrow");
		LuaDLL.lua_pushinteger(l, 274);
		LuaDLL.lua_setfield(l, -2, "DownArrow");
		LuaDLL.lua_pushinteger(l, 275);
		LuaDLL.lua_setfield(l, -2, "RightArrow");
		LuaDLL.lua_pushinteger(l, 276);
		LuaDLL.lua_setfield(l, -2, "LeftArrow");
		LuaDLL.lua_pushinteger(l, 277);
		LuaDLL.lua_setfield(l, -2, "Insert");
		LuaDLL.lua_pushinteger(l, 278);
		LuaDLL.lua_setfield(l, -2, "Home");
		LuaDLL.lua_pushinteger(l, 279);
		LuaDLL.lua_setfield(l, -2, "End");
		LuaDLL.lua_pushinteger(l, 280);
		LuaDLL.lua_setfield(l, -2, "PageUp");
		LuaDLL.lua_pushinteger(l, 281);
		LuaDLL.lua_setfield(l, -2, "PageDown");
		LuaDLL.lua_pushinteger(l, 282);
		LuaDLL.lua_setfield(l, -2, "F1");
		LuaDLL.lua_pushinteger(l, 283);
		LuaDLL.lua_setfield(l, -2, "F2");
		LuaDLL.lua_pushinteger(l, 284);
		LuaDLL.lua_setfield(l, -2, "F3");
		LuaDLL.lua_pushinteger(l, 285);
		LuaDLL.lua_setfield(l, -2, "F4");
		LuaDLL.lua_pushinteger(l, 286);
		LuaDLL.lua_setfield(l, -2, "F5");
		LuaDLL.lua_pushinteger(l, 287);
		LuaDLL.lua_setfield(l, -2, "F6");
		LuaDLL.lua_pushinteger(l, 288);
		LuaDLL.lua_setfield(l, -2, "F7");
		LuaDLL.lua_pushinteger(l, 289);
		LuaDLL.lua_setfield(l, -2, "F8");
		LuaDLL.lua_pushinteger(l, 290);
		LuaDLL.lua_setfield(l, -2, "F9");
		LuaDLL.lua_pushinteger(l, 291);
		LuaDLL.lua_setfield(l, -2, "F10");
		LuaDLL.lua_pushinteger(l, 292);
		LuaDLL.lua_setfield(l, -2, "F11");
		LuaDLL.lua_pushinteger(l, 293);
		LuaDLL.lua_setfield(l, -2, "F12");
		LuaDLL.lua_pushinteger(l, 294);
		LuaDLL.lua_setfield(l, -2, "F13");
		LuaDLL.lua_pushinteger(l, 295);
		LuaDLL.lua_setfield(l, -2, "F14");
		LuaDLL.lua_pushinteger(l, 296);
		LuaDLL.lua_setfield(l, -2, "F15");
		LuaDLL.lua_pushinteger(l, 48);
		LuaDLL.lua_setfield(l, -2, "Alpha0");
		LuaDLL.lua_pushinteger(l, 49);
		LuaDLL.lua_setfield(l, -2, "Alpha1");
		LuaDLL.lua_pushinteger(l, 50);
		LuaDLL.lua_setfield(l, -2, "Alpha2");
		LuaDLL.lua_pushinteger(l, 51);
		LuaDLL.lua_setfield(l, -2, "Alpha3");
		LuaDLL.lua_pushinteger(l, 52);
		LuaDLL.lua_setfield(l, -2, "Alpha4");
		LuaDLL.lua_pushinteger(l, 53);
		LuaDLL.lua_setfield(l, -2, "Alpha5");
		LuaDLL.lua_pushinteger(l, 54);
		LuaDLL.lua_setfield(l, -2, "Alpha6");
		LuaDLL.lua_pushinteger(l, 55);
		LuaDLL.lua_setfield(l, -2, "Alpha7");
		LuaDLL.lua_pushinteger(l, 56);
		LuaDLL.lua_setfield(l, -2, "Alpha8");
		LuaDLL.lua_pushinteger(l, 57);
		LuaDLL.lua_setfield(l, -2, "Alpha9");
		LuaDLL.lua_pushinteger(l, 33);
		LuaDLL.lua_setfield(l, -2, "Exclaim");
		LuaDLL.lua_pushinteger(l, 34);
		LuaDLL.lua_setfield(l, -2, "DoubleQuote");
		LuaDLL.lua_pushinteger(l, 35);
		LuaDLL.lua_setfield(l, -2, "Hash");
		LuaDLL.lua_pushinteger(l, 36);
		LuaDLL.lua_setfield(l, -2, "Dollar");
		LuaDLL.lua_pushinteger(l, 38);
		LuaDLL.lua_setfield(l, -2, "Ampersand");
		LuaDLL.lua_pushinteger(l, 39);
		LuaDLL.lua_setfield(l, -2, "Quote");
		LuaDLL.lua_pushinteger(l, 40);
		LuaDLL.lua_setfield(l, -2, "LeftParen");
		LuaDLL.lua_pushinteger(l, 41);
		LuaDLL.lua_setfield(l, -2, "RightParen");
		LuaDLL.lua_pushinteger(l, 42);
		LuaDLL.lua_setfield(l, -2, "Asterisk");
		LuaDLL.lua_pushinteger(l, 43);
		LuaDLL.lua_setfield(l, -2, "Plus");
		LuaDLL.lua_pushinteger(l, 44);
		LuaDLL.lua_setfield(l, -2, "Comma");
		LuaDLL.lua_pushinteger(l, 45);
		LuaDLL.lua_setfield(l, -2, "Minus");
		LuaDLL.lua_pushinteger(l, 46);
		LuaDLL.lua_setfield(l, -2, "Period");
		LuaDLL.lua_pushinteger(l, 47);
		LuaDLL.lua_setfield(l, -2, "Slash");
		LuaDLL.lua_pushinteger(l, 58);
		LuaDLL.lua_setfield(l, -2, "Colon");
		LuaDLL.lua_pushinteger(l, 59);
		LuaDLL.lua_setfield(l, -2, "Semicolon");
		LuaDLL.lua_pushinteger(l, 60);
		LuaDLL.lua_setfield(l, -2, "Less");
		LuaDLL.lua_pushinteger(l, 61);
		LuaDLL.lua_setfield(l, -2, "Equals");
		LuaDLL.lua_pushinteger(l, 62);
		LuaDLL.lua_setfield(l, -2, "Greater");
		LuaDLL.lua_pushinteger(l, 63);
		LuaDLL.lua_setfield(l, -2, "Question");
		LuaDLL.lua_pushinteger(l, 64);
		LuaDLL.lua_setfield(l, -2, "At");
		LuaDLL.lua_pushinteger(l, 91);
		LuaDLL.lua_setfield(l, -2, "LeftBracket");
		LuaDLL.lua_pushinteger(l, 92);
		LuaDLL.lua_setfield(l, -2, "Backslash");
		LuaDLL.lua_pushinteger(l, 93);
		LuaDLL.lua_setfield(l, -2, "RightBracket");
		LuaDLL.lua_pushinteger(l, 94);
		LuaDLL.lua_setfield(l, -2, "Caret");
		LuaDLL.lua_pushinteger(l, 95);
		LuaDLL.lua_setfield(l, -2, "Underscore");
		LuaDLL.lua_pushinteger(l, 96);
		LuaDLL.lua_setfield(l, -2, "BackQuote");
		LuaDLL.lua_pushinteger(l, 97);
		LuaDLL.lua_setfield(l, -2, "A");
		LuaDLL.lua_pushinteger(l, 98);
		LuaDLL.lua_setfield(l, -2, "B");
		LuaDLL.lua_pushinteger(l, 99);
		LuaDLL.lua_setfield(l, -2, "C");
		LuaDLL.lua_pushinteger(l, 100);
		LuaDLL.lua_setfield(l, -2, "D");
		LuaDLL.lua_pushinteger(l, 101);
		LuaDLL.lua_setfield(l, -2, "E");
		LuaDLL.lua_pushinteger(l, 102);
		LuaDLL.lua_setfield(l, -2, "F");
		LuaDLL.lua_pushinteger(l, 103);
		LuaDLL.lua_setfield(l, -2, "G");
		LuaDLL.lua_pushinteger(l, 104);
		LuaDLL.lua_setfield(l, -2, "H");
		LuaDLL.lua_pushinteger(l, 105);
		LuaDLL.lua_setfield(l, -2, "I");
		LuaDLL.lua_pushinteger(l, 106);
		LuaDLL.lua_setfield(l, -2, "J");
		LuaDLL.lua_pushinteger(l, 107);
		LuaDLL.lua_setfield(l, -2, "K");
		LuaDLL.lua_pushinteger(l, 108);
		LuaDLL.lua_setfield(l, -2, "L");
		LuaDLL.lua_pushinteger(l, 109);
		LuaDLL.lua_setfield(l, -2, "M");
		LuaDLL.lua_pushinteger(l, 110);
		LuaDLL.lua_setfield(l, -2, "N");
		LuaDLL.lua_pushinteger(l, 111);
		LuaDLL.lua_setfield(l, -2, "O");
		LuaDLL.lua_pushinteger(l, 112);
		LuaDLL.lua_setfield(l, -2, "P");
		LuaDLL.lua_pushinteger(l, 113);
		LuaDLL.lua_setfield(l, -2, "Q");
		LuaDLL.lua_pushinteger(l, 114);
		LuaDLL.lua_setfield(l, -2, "R");
		LuaDLL.lua_pushinteger(l, 115);
		LuaDLL.lua_setfield(l, -2, "S");
		LuaDLL.lua_pushinteger(l, 116);
		LuaDLL.lua_setfield(l, -2, "T");
		LuaDLL.lua_pushinteger(l, 117);
		LuaDLL.lua_setfield(l, -2, "U");
		LuaDLL.lua_pushinteger(l, 118);
		LuaDLL.lua_setfield(l, -2, "V");
		LuaDLL.lua_pushinteger(l, 119);
		LuaDLL.lua_setfield(l, -2, "W");
		LuaDLL.lua_pushinteger(l, 120);
		LuaDLL.lua_setfield(l, -2, "X");
		LuaDLL.lua_pushinteger(l, 121);
		LuaDLL.lua_setfield(l, -2, "Y");
		LuaDLL.lua_pushinteger(l, 122);
		LuaDLL.lua_setfield(l, -2, "Z");
		LuaDLL.lua_pushinteger(l, 300);
		LuaDLL.lua_setfield(l, -2, "Numlock");
		LuaDLL.lua_pushinteger(l, 301);
		LuaDLL.lua_setfield(l, -2, "CapsLock");
		LuaDLL.lua_pushinteger(l, 302);
		LuaDLL.lua_setfield(l, -2, "ScrollLock");
		LuaDLL.lua_pushinteger(l, 303);
		LuaDLL.lua_setfield(l, -2, "RightShift");
		LuaDLL.lua_pushinteger(l, 304);
		LuaDLL.lua_setfield(l, -2, "LeftShift");
		LuaDLL.lua_pushinteger(l, 305);
		LuaDLL.lua_setfield(l, -2, "RightControl");
		LuaDLL.lua_pushinteger(l, 306);
		LuaDLL.lua_setfield(l, -2, "LeftControl");
		LuaDLL.lua_pushinteger(l, 307);
		LuaDLL.lua_setfield(l, -2, "RightAlt");
		LuaDLL.lua_pushinteger(l, 308);
		LuaDLL.lua_setfield(l, -2, "LeftAlt");
		LuaDLL.lua_pushinteger(l, 310);
		LuaDLL.lua_setfield(l, -2, "LeftCommand");
		LuaDLL.lua_pushinteger(l, 310);
		LuaDLL.lua_setfield(l, -2, "LeftApple");
		LuaDLL.lua_pushinteger(l, 311);
		LuaDLL.lua_setfield(l, -2, "LeftWindows");
		LuaDLL.lua_pushinteger(l, 309);
		LuaDLL.lua_setfield(l, -2, "RightCommand");
		LuaDLL.lua_pushinteger(l, 309);
		LuaDLL.lua_setfield(l, -2, "RightApple");
		LuaDLL.lua_pushinteger(l, 312);
		LuaDLL.lua_setfield(l, -2, "RightWindows");
		LuaDLL.lua_pushinteger(l, 313);
		LuaDLL.lua_setfield(l, -2, "AltGr");
		LuaDLL.lua_pushinteger(l, 315);
		LuaDLL.lua_setfield(l, -2, "Help");
		LuaDLL.lua_pushinteger(l, 316);
		LuaDLL.lua_setfield(l, -2, "Print");
		LuaDLL.lua_pushinteger(l, 317);
		LuaDLL.lua_setfield(l, -2, "SysReq");
		LuaDLL.lua_pushinteger(l, 318);
		LuaDLL.lua_setfield(l, -2, "Break");
		LuaDLL.lua_pushinteger(l, 319);
		LuaDLL.lua_setfield(l, -2, "Menu");
		LuaDLL.lua_pushinteger(l, 323);
		LuaDLL.lua_setfield(l, -2, "Mouse0");
		LuaDLL.lua_pushinteger(l, 324);
		LuaDLL.lua_setfield(l, -2, "Mouse1");
		LuaDLL.lua_pushinteger(l, 325);
		LuaDLL.lua_setfield(l, -2, "Mouse2");
		LuaDLL.lua_pushinteger(l, 326);
		LuaDLL.lua_setfield(l, -2, "Mouse3");
		LuaDLL.lua_pushinteger(l, 327);
		LuaDLL.lua_setfield(l, -2, "Mouse4");
		LuaDLL.lua_pushinteger(l, 328);
		LuaDLL.lua_setfield(l, -2, "Mouse5");
		LuaDLL.lua_pushinteger(l, 329);
		LuaDLL.lua_setfield(l, -2, "Mouse6");
		LuaDLL.lua_pushinteger(l, 330);
		LuaDLL.lua_setfield(l, -2, "JoystickButton0");
		LuaDLL.lua_pushinteger(l, 331);
		LuaDLL.lua_setfield(l, -2, "JoystickButton1");
		LuaDLL.lua_pushinteger(l, 332);
		LuaDLL.lua_setfield(l, -2, "JoystickButton2");
		LuaDLL.lua_pushinteger(l, 333);
		LuaDLL.lua_setfield(l, -2, "JoystickButton3");
		LuaDLL.lua_pushinteger(l, 334);
		LuaDLL.lua_setfield(l, -2, "JoystickButton4");
		LuaDLL.lua_pushinteger(l, 335);
		LuaDLL.lua_setfield(l, -2, "JoystickButton5");
		LuaDLL.lua_pushinteger(l, 336);
		LuaDLL.lua_setfield(l, -2, "JoystickButton6");
		LuaDLL.lua_pushinteger(l, 337);
		LuaDLL.lua_setfield(l, -2, "JoystickButton7");
		LuaDLL.lua_pushinteger(l, 338);
		LuaDLL.lua_setfield(l, -2, "JoystickButton8");
		LuaDLL.lua_pushinteger(l, 339);
		LuaDLL.lua_setfield(l, -2, "JoystickButton9");
		LuaDLL.lua_pushinteger(l, 340);
		LuaDLL.lua_setfield(l, -2, "JoystickButton10");
		LuaDLL.lua_pushinteger(l, 341);
		LuaDLL.lua_setfield(l, -2, "JoystickButton11");
		LuaDLL.lua_pushinteger(l, 342);
		LuaDLL.lua_setfield(l, -2, "JoystickButton12");
		LuaDLL.lua_pushinteger(l, 343);
		LuaDLL.lua_setfield(l, -2, "JoystickButton13");
		LuaDLL.lua_pushinteger(l, 344);
		LuaDLL.lua_setfield(l, -2, "JoystickButton14");
		LuaDLL.lua_pushinteger(l, 345);
		LuaDLL.lua_setfield(l, -2, "JoystickButton15");
		LuaDLL.lua_pushinteger(l, 346);
		LuaDLL.lua_setfield(l, -2, "JoystickButton16");
		LuaDLL.lua_pushinteger(l, 347);
		LuaDLL.lua_setfield(l, -2, "JoystickButton17");
		LuaDLL.lua_pushinteger(l, 348);
		LuaDLL.lua_setfield(l, -2, "JoystickButton18");
		LuaDLL.lua_pushinteger(l, 349);
		LuaDLL.lua_setfield(l, -2, "JoystickButton19");
		LuaDLL.lua_pushinteger(l, 350);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button0");
		LuaDLL.lua_pushinteger(l, 351);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button1");
		LuaDLL.lua_pushinteger(l, 352);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button2");
		LuaDLL.lua_pushinteger(l, 353);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button3");
		LuaDLL.lua_pushinteger(l, 354);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button4");
		LuaDLL.lua_pushinteger(l, 355);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button5");
		LuaDLL.lua_pushinteger(l, 356);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button6");
		LuaDLL.lua_pushinteger(l, 357);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button7");
		LuaDLL.lua_pushinteger(l, 358);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button8");
		LuaDLL.lua_pushinteger(l, 359);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button9");
		LuaDLL.lua_pushinteger(l, 360);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button10");
		LuaDLL.lua_pushinteger(l, 361);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button11");
		LuaDLL.lua_pushinteger(l, 362);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button12");
		LuaDLL.lua_pushinteger(l, 363);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button13");
		LuaDLL.lua_pushinteger(l, 364);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button14");
		LuaDLL.lua_pushinteger(l, 365);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button15");
		LuaDLL.lua_pushinteger(l, 366);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button16");
		LuaDLL.lua_pushinteger(l, 367);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button17");
		LuaDLL.lua_pushinteger(l, 368);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button18");
		LuaDLL.lua_pushinteger(l, 369);
		LuaDLL.lua_setfield(l, -2, "Joystick1Button19");
		LuaDLL.lua_pushinteger(l, 370);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button0");
		LuaDLL.lua_pushinteger(l, 371);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button1");
		LuaDLL.lua_pushinteger(l, 372);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button2");
		LuaDLL.lua_pushinteger(l, 373);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button3");
		LuaDLL.lua_pushinteger(l, 374);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button4");
		LuaDLL.lua_pushinteger(l, 375);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button5");
		LuaDLL.lua_pushinteger(l, 376);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button6");
		LuaDLL.lua_pushinteger(l, 377);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button7");
		LuaDLL.lua_pushinteger(l, 378);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button8");
		LuaDLL.lua_pushinteger(l, 379);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button9");
		LuaDLL.lua_pushinteger(l, 380);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button10");
		LuaDLL.lua_pushinteger(l, 381);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button11");
		LuaDLL.lua_pushinteger(l, 382);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button12");
		LuaDLL.lua_pushinteger(l, 383);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button13");
		LuaDLL.lua_pushinteger(l, 384);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button14");
		LuaDLL.lua_pushinteger(l, 385);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button15");
		LuaDLL.lua_pushinteger(l, 386);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button16");
		LuaDLL.lua_pushinteger(l, 387);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button17");
		LuaDLL.lua_pushinteger(l, 388);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button18");
		LuaDLL.lua_pushinteger(l, 389);
		LuaDLL.lua_setfield(l, -2, "Joystick2Button19");
		LuaDLL.lua_pushinteger(l, 390);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button0");
		LuaDLL.lua_pushinteger(l, 391);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button1");
		LuaDLL.lua_pushinteger(l, 392);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button2");
		LuaDLL.lua_pushinteger(l, 393);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button3");
		LuaDLL.lua_pushinteger(l, 394);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button4");
		LuaDLL.lua_pushinteger(l, 395);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button5");
		LuaDLL.lua_pushinteger(l, 396);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button6");
		LuaDLL.lua_pushinteger(l, 397);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button7");
		LuaDLL.lua_pushinteger(l, 398);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button8");
		LuaDLL.lua_pushinteger(l, 399);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button9");
		LuaDLL.lua_pushinteger(l, 400);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button10");
		LuaDLL.lua_pushinteger(l, 401);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button11");
		LuaDLL.lua_pushinteger(l, 402);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button12");
		LuaDLL.lua_pushinteger(l, 403);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button13");
		LuaDLL.lua_pushinteger(l, 404);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button14");
		LuaDLL.lua_pushinteger(l, 405);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button15");
		LuaDLL.lua_pushinteger(l, 406);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button16");
		LuaDLL.lua_pushinteger(l, 407);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button17");
		LuaDLL.lua_pushinteger(l, 408);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button18");
		LuaDLL.lua_pushinteger(l, 409);
		LuaDLL.lua_setfield(l, -2, "Joystick3Button19");
		LuaDLL.lua_pushinteger(l, 410);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button0");
		LuaDLL.lua_pushinteger(l, 411);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button1");
		LuaDLL.lua_pushinteger(l, 412);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button2");
		LuaDLL.lua_pushinteger(l, 413);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button3");
		LuaDLL.lua_pushinteger(l, 414);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button4");
		LuaDLL.lua_pushinteger(l, 415);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button5");
		LuaDLL.lua_pushinteger(l, 416);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button6");
		LuaDLL.lua_pushinteger(l, 417);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button7");
		LuaDLL.lua_pushinteger(l, 418);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button8");
		LuaDLL.lua_pushinteger(l, 419);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button9");
		LuaDLL.lua_pushinteger(l, 420);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button10");
		LuaDLL.lua_pushinteger(l, 421);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button11");
		LuaDLL.lua_pushinteger(l, 422);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button12");
		LuaDLL.lua_pushinteger(l, 423);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button13");
		LuaDLL.lua_pushinteger(l, 424);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button14");
		LuaDLL.lua_pushinteger(l, 425);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button15");
		LuaDLL.lua_pushinteger(l, 426);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button16");
		LuaDLL.lua_pushinteger(l, 427);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button17");
		LuaDLL.lua_pushinteger(l, 428);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button18");
		LuaDLL.lua_pushinteger(l, 429);
		LuaDLL.lua_setfield(l, -2, "Joystick4Button19");
		addMember(l,IntToEnum, "IntToEnum");
		LuaDLL.lua_pop(l, 1);
	}
}
