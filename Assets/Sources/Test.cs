using UnityEngine;
using System.Collections;

public class Test: MonoBehaviour 
{
	public int a = 10;
	public float b = 0.1f;
	public string c = "adf유니티";
	public bool d = true;

	int Add(int left, int right)
	{

		int result = left + right;
		return result;
	}

	// Use this for initialization
	void Start () 
	{
		int result ;
		result = Add(50, 100);
		print (result);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
