using UnityEngine;
using System.Collections;

public class AP_Login : MonoBehaviour {
	public tk2dUITextInput IdText;
	public tk2dUITextInput PwText;

	public string MyId;
	public string MyPw;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LoginCheck()
	{

		if(IdText.Text.Length == 0)//아이디가 에러
		{
			animation.Play("FaildLogind");
		}
		else if(PwText.Text.Length == 0)//비번이 에러
		{
			animation.Play("FaildLogind");
		}

		//
		if(IdText.Text.Equals(MyId))
		{
			if(PwText.Text.Equals(MyPw))
			{
				animation.Play("CloseLogin");
				GameObject.FindGameObjectWithTag("MainLayer").SendMessage("OpenBar");
			}
			else
			{
				animation.Play("FaildLogind");
			}
		}
		else
		{
			animation.Play("FaildLogind");
		}
	}
}
