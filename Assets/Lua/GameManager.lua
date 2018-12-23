GameManager={};

require("ResourcesManager")
require("Math")

function GameManager:Awake()
	print("init GameManager");
	ResourcesManager.Awake();

end


function Start()
	-- body
	print("GameManager -- Start")
	print(Math:Max(2,1));

end

function GameManager:Update()
	-- body
	--print("GameManager Update");
end

GameManager.Awake();
Start();

return GameManager;