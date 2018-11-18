﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoving : MonoBehaviour {

    public GameObject box;

    public GameObject parent;

    public float speed = 0;

    public new Camera camera;


    private List<GameObject> list = new List<GameObject>();

	// Use this for initialization
	void Start () {
        Invoke("GenerateBox", 2.5f);


    }
	
	// Update is called once per frame
	void Update () {


        foreach (var item in list)
        {
            if (item != null) {
                item.transform.Translate(speed * Time.deltaTime, 0, 0);
            }

        }

    }

    private void GenerateBox() {

       

        GameObject adding = Instantiate(box, new Vector3(camera.transform.position.x + 5f, camera.transform.position.y - UnityEngine.Random.Range(3.9f, 5.0f), 0), this.transform.rotation) as GameObject;
       // adding.transform.parent = parent.transform;
        list.Add(adding);

        Destroy(adding, 10);
        
    }


}
