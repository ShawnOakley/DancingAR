using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour {

	public GameObject Zombie;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = Zombie.getComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

	}

	public void changeAnim(){
		Debug.Log("PRESSED");
	}
}
