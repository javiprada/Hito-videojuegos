using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {

    private Jugador_controlador player;

	// Use this for initialization
	void Start () {
        player = GetComponentInParent<Jugador_controlador>();
        
		
	}

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        player.grounded = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
            player.grounded = false;
    }
}
