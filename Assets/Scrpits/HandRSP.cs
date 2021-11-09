using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using System.Linq;
public class HandRSP : MonoBehaviour
{
    private Controller controller;
    private Finger[] fingers;
    private bool[] isGripFingers;
    public enum RSP
    {
        Rock, Scissors, Paper
    };
    public RSP rsp;
    // Use this for initialization
    void Start()
    {
        controller = new Controller();
        fingers = new Finger[5];
        isGripFingers = new bool[5];
    }

    // Update is called once per frame
    void Update()
    {
        Frame frame = controller.Frame();
        if (frame.Hands.Count != 0)
        {
            List<Hand> hand = frame.Hands;
            fingers = hand[0].Fingers.ToArray();
            isGripFingers = Array.ConvertAll(fingers, new Converter<Finger, bool>(i => i.IsExtended));
            Debug.Log(isGripFingers[0] + "," + isGripFingers[1] + "," + isGripFingers[2] + "," + isGripFingers[3] + "," + isGripFingers[4]);
            int extendedFingerCount = isGripFingers.Count(n => n == true);
            if (extendedFingerCount == 0)
            {
                rsp = RSP.Rock;
            }
            else if (extendedFingerCount < 4)
            {
                rsp = RSP.Scissors;

            }
            else
            {
                rsp = RSP.Paper;

            }

        }
    }
}