using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Car {

    public float speed;
    public string color;
    public int highestSpeed;

    public Car()
    {
        Debug.Log("Car() Called");
    }

    public Car(float speed)
    {
        this.speed = speed;
        Debug.Log("Car(float) Called");
    }

    public Car(float s, string c)
    {
        this.speed = s;
        this.color = c;
        Debug.Log("Car(float, string) called");
    }

    void Move()
    {
        Debug.Log("Moving");
    }

    void ApplyBrake()
    {
        Debug.Log("Applying Brake");
    }

    public void CarSpeed()
    {
        Debug.Log(speed);
    }

    public void PrintCarDetails()
    {
        Debug.Log("Speed = " + speed);
        Debug.Log("Color = " + color);
        Debug.Log("HighestSpeed = " + highestSpeed);
    }

}
