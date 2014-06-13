using UnityEngine;
using System.Collections;
using System;

public class AP_MealLayer : MonoBehaviour {


	string[] split_value;
	string[] split_string = { "#$!" };

	string[] meal_string;

	public int now_day = 1;
	public tk2dTextMesh text_mesh;
    WWW www;

    

	// Use this for initialization
	void Start () {
        string url = "http://hes.use.go.kr/sts_sci_md00_003.do?schulCode=H100000530&schulCrseScCode=4&schulKndScCode=04&schMmealScCode=2&schYm=";
        url += DateTime.Now.ToString("yyyy");
        url += ".";
        url += DateTime.Now.ToString("MM");

        now_day = Convert.ToInt16(DateTime.Now.ToString("dd"));
        www = new WWW(url);
        
		StartCoroutine(WaitForRequest());
	}
	
	// Update is called once per frame
	void Update () {
        //if (meal_string[now_day - 1] != null)
        //{
        //    text_mesh.text = meal_string[now_day - 1];
        //   text_mesh.Commit();
        //}


	
	}

    private IEnumerator WaitForRequest()
    {
        yield return www;
        // check for errors 
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }

		string ori_value = www.text;
		split_value = ori_value.Split(split_string,System.StringSplitOptions.RemoveEmptyEntries);
		print(split_string);

        meal_string = new string[31];
        string[] temp;
        string[] split_str = { "[조식]", "[중식]", "[석식]" };
		for(int i = 0; i<31; i++)
		{
			meal_string[i] = split_value[i+2];
            temp = meal_string[i].Split(split_str,StringSplitOptions.None);
		}


    } 
}
