var displayText : UnityEngine.UI.Text;
var currentEmployees : int;
var potentialEmployees : int; //Number of total offices?

function Start(){
	currentEmployees = 3;
	potentialEmployees = 5;
}

function Update() {
	displayText.text = "Employes: " + currentEmployees.ToString() + " of " + potentialEmployees.ToString();
}