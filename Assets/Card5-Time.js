var displayText : UnityEngine.UI.Text;
var displayText_day : UnityEngine.UI.Text;
var day : int;
var timeLeft : int;

function Start() {
	timeLeft = 120.0f;
	day = 0;
	displayText.text = "Time left: " + timeLeft.ToString();
	InvokeRepeating("Countdown", 1.0, 1.0);
}

function Update(){
	displayText_day.text = "Days: " + day.ToString();
}

function Countdown() {
	if (--timeLeft == 0){
		day += 1;
		timeLeft = 120.0f;
	}
	displayText.text = "Time left: " + timeLeft.ToString();
}