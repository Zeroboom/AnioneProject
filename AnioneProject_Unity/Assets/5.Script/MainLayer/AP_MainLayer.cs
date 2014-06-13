using UnityEngine;
using System.Collections;


public class AP_MainLayer : MonoBehaviour {
	public GameObject Bar;

	enum eState
	{
		eNaviGationOpen,
		eNaviGationClose,
	}

    eState LayerState;
	// Use this for initialization
	void Start () {
        LayerState = eState.eNaviGationClose;
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnNavigationButton()
    {
        if(LayerState == eState.eNaviGationClose)
        {
            OpenNavigationLayer();
            
        }
        else
        {
            CloseNavigationLayer();
            
        }
    }
    void OpenNavigationLayer()
    {
        animation.Play("OpenNavigation");
        LayerState = eState.eNaviGationOpen;
    }

    void CloseNavigationLayer()
    {
        animation.Play("CloseNavigation");
        LayerState = eState.eNaviGationClose;
    }

	void OpenBar()
	{
		Bar.animation.Play("OpenBar");
	}
}
