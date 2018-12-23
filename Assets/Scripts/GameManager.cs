using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public LuaEngine luaEngine;

	void Start () {

        luaEngine = GetComponent<LuaEngine>();


	}
	
	void Update () {
		
	}
}
