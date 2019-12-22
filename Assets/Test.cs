using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;


	public void Magic(int damage) {

		if (this.mp < damage) {

			Debug.Log ("MPが足りないため魔法が使えない。");
			
		} else {

			this.mp -= damage;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int[] array = new int[5];

		array [0] = 60;
		array [1] = 70;
		array [2] = 100;
		array [3] = 95;
		array [4] = 87;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		for (int h = 4; h >= 0; h--) {
			Debug.Log (array [h]);
		}

		Boss lastboss = new Boss ();

		for (int j = 0; j < 11; j++) {
			
			lastboss.Magic (5);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
