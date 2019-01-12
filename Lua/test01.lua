local GameObject = UnityEngine.GameObject
local go;
local tran;
local isShow=true;

function awake()
	if (isShow) then
		print("this is lua awake")
	end

	go = GameObject("go");
	tran = go.transform;
	tran.position=Vector3.one;
end

function update()
	if(isShow) then
		print("this is lua update")
	end
	
end

function onDestroy()
	if(isShow) then
		print("this is lua onDestroy")
	end

end


