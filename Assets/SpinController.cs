using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinController : MonoBehaviour {
	public bool isSpinning;
	private float resetTimer = 30;

	void Start () {
		isSpinning = false;
	}

	void Update () {
		if(isSpinning) transform.Rotate(new Vector3(0,3f,0));
		if (Input.GetMouseButton(0) && resetTimer > 30) {
			isSpinning = !isSpinning;
			resetTimer = 0;
		}
		resetTimer += 1;
	}
}
