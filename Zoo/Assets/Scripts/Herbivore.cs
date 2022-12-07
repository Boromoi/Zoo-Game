﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Herbivore : Animal, IHerbivore
{
    public Button leavesButton;

    public override void Start()
    {
        base.Start();

        // Set the type of animal
        type = "Herbivore";

        // Get all the refrences to the objects
        leavesButton = GameObject.FindGameObjectWithTag("LeavesButton").GetComponent<Button>();

        // Add the onClick event Listeners to the right methods
        leavesButton.onClick.AddListener(EatLeaves);
    }

    // Eat leaves and say text in the textBalloon
    public virtual void EatLeaves()
    {
        Balloon.SetActive(true);
    }
}