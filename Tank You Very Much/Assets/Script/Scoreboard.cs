using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    private TankControls p1;
    private TankControls p2;
    private Text scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("P1").GetComponent<TankControls>();
        p2 = GameObject.FindGameObjectWithTag("P2").GetComponent<TankControls>();
        scoreBoard = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreBoard.text = p1.GetScore() + " - " + p2.GetScore();
    }
}
