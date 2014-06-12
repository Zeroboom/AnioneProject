using UnityEngine;
using System.Collections;

public class Anione_Login : MonoBehaviour {
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

		if(IdText.Text.Length == 0)//아이디가 비엇을 경우
		{
			animation.Play("FaildLogind");
		}
		else if(PwText.Text.Length == 0)//비번이 비엇을 경우
		{
			animation.Play("FaildLogind");
		}

		//나중에는 예일문이용해서 검사하고 넘기는 방법으로 해야함.
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
