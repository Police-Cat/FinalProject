using UnityEngine;
using System.Collections;

public class OpenAnimTest: MonoBehaviour {

	Animator anim;
	bool open = false;
	void Start () {
	
		anim = GetComponent<Animator>();

	}

	void OnMouseDown(){

		if (!open){

			open = true;
			anim.SetBool("open", open);

		} else {

			open = false;
			anim.SetBool("open", open);


		}

	}

}
