Math={}

function Math:Max(a,b)
	if type(a)=="number" and type(b)=="number" then
		if a >= b then 
			return a ;
		else 
			return b ;
		end
	else
		print("param is error");
	end
end



return Math;