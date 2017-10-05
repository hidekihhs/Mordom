﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAControl : MonoBehaviour {

    float distance;
    float proportion;
	float initD;
	Vector2 initSpeed;

	public int score;

    public GameObject planet;

    void Start ()
    {
        float dx = planet.transform.position.x - transform.position.x;
        float dy = planet.transform.position.y - transform.position.y;
		initD = new Vector2(dx, dy).magnitude;
		initSpeed = GetComponent<Rigidbody2D>().velocity;
		score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        float dx = planet.transform.position.x - transform.position.x;
        float dy = planet.transform.position.y - transform.position.y;

        distance = new Vector2(dx, dy).magnitude;
		proportion = (distance / initD) * 3;
        GetComponent<Rigidbody2D>().velocity = initSpeed * proportion;
    }

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Tool") {
			Destroy(this.gameObject);
			score = score + 1;
		}

		print ("Woot");
	}
}