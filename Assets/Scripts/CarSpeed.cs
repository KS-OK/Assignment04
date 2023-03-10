using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour
{
    public static float Speed = 7;
    public Slider ChangeSpeed;
    public Text ShowSpeed;

    public void AdjustSpeed()
    {
        Speed = ChangeSpeed.value;
        ShowSpeed.text = "Car speed: " + Speed.ToString();
    }
}

