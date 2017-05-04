using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour {

    public GameController gC;

    void OnMouseDown()
    {
        Debug.Log("Button Clicked");
        gC.StartGame();
    }
}
