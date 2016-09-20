using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public void LButtonDown()
	{
		this.transform.Translate(-3, 0, 0);
	}

	public void RButtonDown()
	{
		this.transform.Translate(3, 0, 0);
	}
}
