using UnityEngine;
using System.Collections;

public class NavigationScript : MonoBehaviour
{


    public tk2dSprite Button0;
    public tk2dSprite Button1;
    public tk2dSprite Button2;
    public tk2dSprite Button3;
    public tk2dSprite Button4;
    public tk2dSprite Button5;
    public tk2dSprite Button6;
    public tk2dSprite Button7;
    public tk2dSprite Button8;

    //100은 NULL값
    public int Selector = 100;

    tk2dSprite[] ButtonArray = new tk2dSprite[9];



    // Use this for initialization
    void Start()
    {
        ButtonArray[0] = Button0;
        ButtonArray[1] = Button1;
        ButtonArray[2] = Button2;
        ButtonArray[3] = Button3;
        ButtonArray[4] = Button4;
        ButtonArray[5] = Button5;
        ButtonArray[6] = Button6;
        ButtonArray[7] = Button7;
        ButtonArray[8] = Button8;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnButton0()
    {
        ReShowButton(0);
    }

    void OnButton1()
    {
        ReShowButton(1);
    }

    void OnButton2()
    {
        ReShowButton(2);
    }
    void OnButton3()
    {
        ReShowButton(3);
    }
    void OnButton4()
    {
        ReShowButton(4);
    }
    void OnButton5()
    {
        ReShowButton(5);
    }
    void OnButton6()
    {
        ReShowButton(6);
    }
    void OnButton7()
    {
        ReShowButton(7);
    }
    void OnButton8()
    {
        ReShowButton(8);
    }

    void ReShowButton(int NextSelector)
    {
        if (Selector != 100)
        {
            ButtonArray[Selector].color = new Color(255, 255, 255, 0);
            ButtonArray[Selector].ForceBuild();
        }

        Selector = NextSelector;

        ButtonArray[Selector].color = new Color(255, 255, 255, 255);
        ButtonArray[Selector].ForceBuild();

        GameObject.FindGameObjectWithTag("MainLayer").SendMessage("CloseNavigationLayer");


    }

}
