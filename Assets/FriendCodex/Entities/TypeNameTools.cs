using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp.Entities
{
public class TypeNameTools : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Dictionary<string, TypeName> StringToEnum{ get; set; }

	public  TypeNameTools()
		{
			StringToEnum = new Dictionary<string, TypeName>();
			InitDictionary ();
		}
	

	public void InitDictionary()
	{
		StringToEnum.Add ("MOODY", TypeName.MOODY);
		StringToEnum.Add ("HAPPY", TypeName.HAPPY);
		StringToEnum.Add ("DRAMATIC", TypeName.DRAMATIC);
		StringToEnum.Add ("EASYGOING", TypeName.EASYGOING);
		StringToEnum.Add ("SPUNKY", TypeName.SPUNKY);
		StringToEnum.Add ("SLEEPY", TypeName.SLEEPY);
		StringToEnum.Add ("GRUMPY", TypeName.GRUMPY);
		StringToEnum.Add ("FRIENDLY", TypeName.FRIENDLY);
		StringToEnum.Add ("FUNNY", TypeName.FUNNY);
		StringToEnum.Add ("SERIOUS", TypeName.SERIOUS);
	}

	}
}
