using UnityEngine;
using System.Collections;

public class Anione_Form : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.parent = GameObject.FindGameObjectWithTag("NoticeList").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
