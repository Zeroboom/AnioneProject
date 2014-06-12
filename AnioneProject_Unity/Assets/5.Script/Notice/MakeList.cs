using UnityEngine;
using System.Collections;

public class MakeList : MonoBehaviour {
    //누군가 임의로 설정 할 수 있는 값
    public int FormCount = 0;
    
    public GameObject Form;
    public float OffsetForm = 0.4f;
    float OffsetY = 2.635f;
    float OriginY = 6.19f;
	// Use this for initialization
	void Start () {
	}

    void ResetList()
    {
        GameObject.FindGameObjectWithTag("ScrollArea").GetComponent<tk2dUIScrollableArea>().ContentLength = FormCount * OffsetForm;
		GameObject[] obj_Array = GameObject.FindGameObjectsWithTag("Form");

		if(obj_Array.Length != 0)
		{
			for(int i =0; i<FormCount ; i++)
			{
				Destroy(obj_Array[i]);
			}
		}

		for(int i =0; i<FormCount ; i++)
		{
			Instantiate(Form,new Vector3(0, OriginY + (OffsetY * -i), 8), new Quaternion(0,0,0,0));
		}

    }
	
	// Update is called once per frame
	void Update () {

	
	}
}
