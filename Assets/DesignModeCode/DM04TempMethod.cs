using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM04TempMethod : MonoBehaviour {

	// Use this for initialization
	void Start () {
        IPeople people = new SouthPeople();
        people.Eat();

        people = new NorthPeople();
        people.Eat();
		
	}
	
}

public abstract class IPeople
{
    public void Eat() {
        OrderFoods();
        EatSomething();
        PayBill();
    }

    private void OrderFoods()
    {
        Debug.Log("点单");
    }

    protected virtual void EatSomething() { }

    private void PayBill()
    {
        Debug.Log("买单");
    }
}


public class NorthPeople:IPeople
{
    protected override void EatSomething()
    {
        Debug.Log("我在吃面条");
    }
}

public class SouthPeople : IPeople
{
    protected override void EatSomething()
    {
        Debug.Log("我在吃米饭");
    }
}