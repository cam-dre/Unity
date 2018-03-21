using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardPractice : MonoBehaviour {
    int min = 0;
    int max = 0;
    int guess = 0;
    bool valuesInitialized = false;
    bool selectionMade = false;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    void StartGame() {
        print("=========================");
        print("Welcome to Number Wizard\nPlease select a number range!");
        print("Left arrow = 1 - 100\nUp arrow = 1 - 1000\nRight arrow = 1 - 10000\nDown arrow = 1 - 100000");
    }

    // Update is called once per frame
    void Update() {
        if (valuesInitialized == false && selectionMade == false) {
            System.Random rand = new System.Random();
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                print("1 - 100 Chosen");
                min = 1;
                max = 100;
                guess = rand.Next(min, max);
                valuesInitialized = true;
            } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
                print("1 - 1000 Chosen");
                min = 1;
                max = 1000;
                guess = rand.Next(min, max);
                valuesInitialized = true;
            } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                print("1 - 10000 Chosen");
                min = 1;
                max = 10000;
                guess = rand.Next(min, max);
                valuesInitialized = true;
            } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                print("1 - 100000 Chosen");
                min = 1;
                max = 100000;
                guess = rand.Next(min, max);
                valuesInitialized = true;
            }
        } else if (valuesInitialized == true  && selectionMade == false) {
            selectionMade = true;
            FirstGuess();
        } else {
            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                min = guess;
                NextGuess();
            } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
                max = guess;
                NextGuess();
            } else if (Input.GetKeyDown(KeyCode.Return)) {
                print("I won!");
                valuesInitialized = false;
                selectionMade = false;
                StartGame();
            }
        }
    }

    void FirstGuess() {
        print("Pick a number in your head, but don't tell me!");
        print("The higest number you can pick is " + max);
        print("The lowest you can pick is " + min);
        print("Is the number higher or lower than " + guess + "?");
        print("Up arrow = higher, down = lower, return = equal");
        max += 1;
    }

    void NextGuess() {
        System.Random rand = new System.Random();
        guess = rand.Next(min, max);
        print("Higher or lower than " + guess + "?");
        print("Up arrow = higher, down = lower, return = equal");
    }
}