public var maxLimit : double;
public var minLimit : double;

public var day01Amount : double;
public var day02Amount : double;
public var day03Amount : double;
public var day04Amount : double;
public var day05Amount : double;
public var day06Amount : double;
public var day07Amount : double;
public var day08Amount : double;
public var day09Amount : double;
public var day10Amount : double;
public var day11Amount : double;
public var day12Amount : double;
public var day13Amount : double;
public var day14Amount : double;
public var day15Amount : double;
public var day16Amount : double;
public var day17Amount : double;

public var day01 : GameObject;
public var day02 : GameObject;
public var day03 : GameObject;
public var day04 : GameObject;
public var day05 : GameObject;
public var day06 : GameObject;
public var day07 : GameObject;
public var day08 : GameObject;
public var day09 : GameObject;
public var day10 : GameObject;
public var day11 : GameObject;
public var day12 : GameObject;
public var day13 : GameObject;
public var day14 : GameObject;
public var day15 : GameObject;
public var day16 : GameObject;
public var day17 : GameObject;

function Start() {
	maxLimit = 40.5f;
	minLimit = 0.0f;
	day01Amount = 5.0f;
	day02Amount = 10.0f;
	day03Amount = 15.0f;
	day04Amount = 20.0f;
	day05Amount = 25.0f;
	day06Amount = 30.0f;
	day07Amount = 36.0f;
	day08Amount = 40.0f;
	day09Amount = 40.0f;
	day10Amount = 39.0f;
	day11Amount = 26.0f;
	day12Amount = 19.0f;
	day13Amount = 10.0f;
	day14Amount = 12.0f;
	day15Amount = 15.0f;
	day16Amount = 5.0f;
	day17Amount = 12.0f;
}

//It's a mess
function Update() {
	if (day01Amount > minLimit && day01Amount < maxLimit ) day01.transform.localScale = new Vector3(transform.localScale.x, day01Amount, transform.localScale.y);
    if (day01Amount < minLimit) day01Amount = minLimit;
    if (day01Amount > maxLimit) day01Amount = maxLimit;
    
    if (day02Amount > minLimit && day02Amount < maxLimit ) day02.transform.localScale = new Vector3(transform.localScale.x, day02Amount, transform.localScale.y);
    if (day02Amount < minLimit) day02Amount = minLimit;
    if (day02Amount > maxLimit) day02Amount = maxLimit;
    
    if (day03Amount > minLimit && day03Amount < maxLimit ) day03.transform.localScale = new Vector3(transform.localScale.x, day03Amount, transform.localScale.y);
    if (day03Amount < minLimit) day03Amount = minLimit;
    if (day03Amount > maxLimit) day03Amount = maxLimit;
    
    if (day04Amount > minLimit && day04Amount < maxLimit ) day04.transform.localScale = new Vector3(transform.localScale.x, day04Amount, transform.localScale.y);
    if (day04Amount < minLimit) day04Amount = minLimit;
    if (day04Amount > maxLimit) day04Amount = maxLimit;
    
    if (day05Amount > minLimit && day05Amount < maxLimit ) day05.transform.localScale = new Vector3(transform.localScale.x, day05Amount, transform.localScale.y);
    if (day05Amount < minLimit) day05Amount = minLimit;
    if (day05Amount > maxLimit) day05Amount = maxLimit;
    
    if (day06Amount > minLimit && day06Amount < maxLimit ) day06.transform.localScale = new Vector3(transform.localScale.x, day06Amount, transform.localScale.y);
    if (day06Amount < minLimit) day06Amount = minLimit;
    if (day06Amount > maxLimit) day06Amount = maxLimit;
    
    if (day07Amount > minLimit && day07Amount < maxLimit ) day07.transform.localScale = new Vector3(transform.localScale.x, day07Amount, transform.localScale.y);
    if (day07Amount < minLimit) day07Amount = minLimit;
    if (day07Amount > maxLimit) day07Amount = maxLimit;
    
    if (day08Amount > minLimit && day08Amount < maxLimit ) day08.transform.localScale = new Vector3(transform.localScale.x, day08Amount, transform.localScale.y);
    if (day08Amount < minLimit) day08Amount = minLimit;
    if (day08Amount > maxLimit) day08Amount = maxLimit;
    
    if (day09Amount > minLimit && day09Amount < maxLimit ) day09.transform.localScale = new Vector3(transform.localScale.x, day09Amount, transform.localScale.y);
    if (day09Amount < minLimit) day09Amount = minLimit;
    if (day09Amount > maxLimit) day09Amount = maxLimit;
    
    if (day10Amount > minLimit && day10Amount < maxLimit ) day10.transform.localScale = new Vector3(transform.localScale.x, day10Amount, transform.localScale.y);
    if (day10Amount < minLimit) day10Amount = minLimit;
    if (day10Amount > maxLimit) day10Amount = maxLimit;
    
    if (day10Amount > minLimit && day10Amount < maxLimit ) day10.transform.localScale = new Vector3(transform.localScale.x, day10Amount, transform.localScale.y);
    if (day10Amount < minLimit) day10Amount = minLimit;
    if (day10Amount > maxLimit) day10Amount = maxLimit;
    
    if (day10Amount > minLimit && day10Amount < maxLimit ) day10.transform.localScale = new Vector3(transform.localScale.x, day10Amount, transform.localScale.y);
    if (day10Amount < minLimit) day10Amount = minLimit;
    if (day10Amount > maxLimit) day10Amount = maxLimit;
    
    if (day11Amount > minLimit && day11Amount < maxLimit ) day11.transform.localScale = new Vector3(transform.localScale.x, day11Amount, transform.localScale.y);
    if (day11Amount < minLimit) day11Amount = minLimit;
    if (day11Amount > maxLimit) day11Amount = maxLimit;
    
    if (day12Amount > minLimit && day12Amount < maxLimit ) day12.transform.localScale = new Vector3(transform.localScale.x, day12Amount, transform.localScale.y);
    if (day12Amount < minLimit) day12Amount = minLimit;
    if (day12Amount > maxLimit) day12Amount = maxLimit;
    
    if (day13Amount > minLimit && day13Amount < maxLimit ) day13.transform.localScale = new Vector3(transform.localScale.x, day13Amount, transform.localScale.y);
    if (day13Amount < minLimit) day13Amount = minLimit;
    if (day13Amount > maxLimit) day13Amount = maxLimit;
    
    if (day14Amount > minLimit && day14Amount < maxLimit ) day14.transform.localScale = new Vector3(transform.localScale.x, day14Amount, transform.localScale.y);
    if (day14Amount < minLimit) day14Amount = minLimit;
    if (day14Amount > maxLimit) day14Amount = maxLimit;
    
    if (day15Amount > minLimit && day15Amount < maxLimit ) day15.transform.localScale = new Vector3(transform.localScale.x, day15Amount, transform.localScale.y);
    if (day15Amount < minLimit) day15Amount = minLimit;
    if (day15Amount > maxLimit) day15Amount = maxLimit;
    
    if (day16Amount > minLimit && day16Amount < maxLimit ) day16.transform.localScale = new Vector3(transform.localScale.x, day16Amount, transform.localScale.y);
    if (day16Amount < minLimit) day16Amount = minLimit;
    if (day16Amount > maxLimit) day16Amount = maxLimit;
    
    if (day17Amount > minLimit && day17Amount < maxLimit ) day17.transform.localScale = new Vector3(transform.localScale.x, day17Amount, transform.localScale.y);
    if (day17Amount < minLimit) day17Amount = minLimit;
    if (day17Amount > maxLimit) day17Amount = maxLimit;
}

//Broken fucking shit ass class fuck JavaScript
//public class barChart extends MonoBehaviour{
//
//	public class barGrowth {
//	
//			public var amount : int;
//			public var day : int;
//
//			public function barGrowth(_amount : int, _day : int) {
//				amount = _amount;
//				day = _day;
//			}
//			
//			//Constructor
//			public function barGrowth(){
//				amount = 1;
//				day = 1;
//			}
//		
//		public function addAmount() {
//		
//			if (amount > 0.0f && amount < 40.5f ){
//	    		amount.transform.localScale = new Vector3(transform.localScale.x, amount, transform.localScale.y);
//		    }
//		    
//		    if (amount < 0.0f){
//		    	amount = 0.0f;
//		    }
//		    
//		    if (amount > 40.5f){
//		    	amount = 40.5f;
//	    	}
//		}
//	}
//
//	public var testCalling : barGrowth = new barChart(50, 2);
//
//	function Start(){
//		Debug.Log(test.amount);
//	}
//}