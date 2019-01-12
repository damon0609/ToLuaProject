using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
public class FromLua : MonoBehaviour {

    LuaState luaState;
    LuaFunction lua_awake;
    LuaFunction lua_update;
    LuaFunction lua_onDestroy;
	void Start () {

        string path = @"D:\Damon\Year_2019\Private\Project_Lua\ToLuaProject\Lua\test01.lua";
        luaState = new LuaState();
        luaState.Start();
        LuaBinder.Bind(luaState);
        luaState.DoFile(path);


        lua_awake = luaState.GetFunction("awake");
        lua_awake.Call();

        lua_update = luaState.GetFunction("update");
        lua_onDestroy=luaState.GetFunction("onDestroy");
    }
	
	void Update () {

        lua_update.Call();


    }

    void OnDestroy()
    {
        lua_onDestroy.Call();
    }
}
