using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameendmenu : MonoBehaviour
{

    [Header("Main Menu Buttons")]
    public Button startButton;




    // Start is called before the first frame update
    void Start()
    {

        //Hook events
        startButton.onClick.AddListener(StartGame);


    }



    public void StartGame()
    {
        Debug.Log("start");
        SceneTransitionManager.singleton.GoToSceneAsync(0);
    }


}
