using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class LuaEngine : LuaClient
{

    protected override LuaFileUtils InitLoader()
    {
        return new LuaResLoader();
    }

    protected override void LoadLuaFiles()
    {
        base.LoadLuaFiles();
        luaState.AddSearchPath(Application.dataPath+"/lua");
        OpenLibs();
    }

}
