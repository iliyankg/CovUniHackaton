var amount : double;
var minLimit : double = 0.0f;
var maxLimit : double = 276.0f;

function Start(){
	amount = 67.0f;
}

function Update() {
	if (amount > minLimit && amount < maxLimit ){
    	transform.localScale = new Vector3(transform.localScale.x, amount, transform.localScale.y);
    }
    
    if (amount < minLimit){
    	amount = minLimit;
    }
    	
    if (amount > maxLimit){
    	amount = maxLimit;
    }
}