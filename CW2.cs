using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW2 : MonoBehaviour
{
    // Definne Hero's name and age
    string name = "mahdi";
    int age = 54;
    bool ishero = false;
    float speed = 25.7f;
    int speedboost = 12;
    }

// run the code to see the output
{ 
    void Start()
    
    float runSpeed = speed * 1.5;
    //printing a short story relating to the hero
    print("The dude's name is " + name + "and his age is " + age);
    print("The prophecy says that he is a " + ishero + "hero, with a speed of " + Speed + "KM/h");
    print("He recieved a speed boost of " + (speed + speedBoost));
    print("He has a running speed of " + runspeed);
    }

