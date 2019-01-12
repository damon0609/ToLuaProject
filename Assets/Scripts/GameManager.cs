using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
public class GameManager : MonoBehaviour
{

    LuaState luaState;

    LuaFunction gameManagerUpdate;
    LuaFunction max;

    void Start()
    {

        luaState = new LuaState();
        luaState.Start();

        string luaStr = @"print('this is lua ')";
        luaState.DoString(luaStr, "GameManager.cs");

        string path = Application.dataPath + "/Lua";
        luaState.AddSearchPath(path);

        luaState.DoFile("GameManager.lua");
        luaState.DoFile("Math.lua");

        gameManagerUpdate = luaState.GetFunction("GameManager.Update");

        max = luaState.GetFunction("Math.Max");

        if (max != null)
        {
            //max.BeginPCall();
            //max.Push(2,3);
        }
    }

    void Update()
    {
        if (gameManagerUpdate != null)
            gameManagerUpdate.Call();


    }

    void OnDestroy()
    {
        gameManagerUpdate.Dispose();
        gameManagerUpdate = null;

        luaState.CheckTop();
        luaState.Dispose();
    }
}
