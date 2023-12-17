using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{

    public Button StartButton;

    // Start is called before the first frame update
    void Start()
    {
        
        //Adding listener to the button click event 
        StartButton.onClick.addListener(StartGame);

    }

    // Update is called once per frame
    void Update()
    {
        
        //Adding my start code to the game here
        Debug.log("Game Satrted!!");
    }
}
