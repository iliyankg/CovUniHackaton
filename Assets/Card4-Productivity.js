var displayText : UnityEngine.UI.Text;
public var producPercentage : float;

function Start () {
	producPercentage = 52.4;
}

function Update () {
	displayText.text = producPercentage.ToString() + "%";
}