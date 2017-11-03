using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject board;
	private int playerSide;

	void Awake() {
		playerSide = Random.Range (0, 1);
	}

	public int GetPlayerSide() {
		return playerSide;
	}

	void ChangeSides() {
		playerSide ^= 1;
	}

	void SetControllerRef() {
		board.GetComponent<Board> ().SetControllerRef (this);
	}
}
