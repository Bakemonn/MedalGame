using System.Collections;using System.Collections.Generic;using UnityEngine;public class Ball : MonoBehaviour {    public GameObject obj;    public Rigidbody rb;    bool hitBat;	// Use this for initialization	void Start () {        obj = gameObject;        rb = obj.GetComponent<Rigidbody>();        hitBat = false;	}

    // Update is called once per frame
    void Update() {
        //ボールがバットに当たるまで力を加える
        if (hitBat == false) {
            rb.AddForce(0, 0, -1, ForceMode.Impulse);
        }    }    void Hit()
    {
        this.hitBat = true;
    }}