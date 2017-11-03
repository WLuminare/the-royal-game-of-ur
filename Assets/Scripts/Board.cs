using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

	public GameObject[] warZone;
	public GameObject[] player0Zone;
	public GameObject[] player1Zone;
	private Controller controller;

	public void SetControllerRef(Controller c) {
		controller = c;
	}
}
