var displayText : UnityEngine.UI.Text;
var budget : int;

function Start(){
	budget = 1000.0f;
}

function Update() {
	displayText.text = "Budget: " + budget.ToString() + " DD";
}