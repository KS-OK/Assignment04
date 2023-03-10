using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSpeed : MonoBehaviour
{
    public static float CarSpawnSpeed = .3f;
    public Slider ChangeSpawnSpeed;
    public Text ShowSpawnSpeed;

    public void ChangeTheSpawnSpeed()
    {
        CarSpawnSpeed = ChangeSpawnSpeed.value;
        if ((ChangeSpawnSpeed.value >= 0.5f) && (ChangeSpawnSpeed.value <= 0.75f))
        {
            ShowSpawnSpeed.text = "Spawn speed: SLOW"; //+ CarSpawnSpeed.ToString();
        }
        else if ((ChangeSpawnSpeed.value > 0.75f) && (ChangeSpawnSpeed.value <= 1f))
        {
            ShowSpawnSpeed.text = "Spawn speed: VERY SLOW"; //+ CarSpawnSpeed.ToString();
        }
        else if ((ChangeSpawnSpeed.value < 0.5f) && (ChangeSpawnSpeed.value >= 0.25f))
        {
            ShowSpawnSpeed.text = "Spawn speed: FAST"; //+ CarSpawnSpeed.ToString();
        }
        else if ((ChangeSpawnSpeed.value < 0.25f) && (ChangeSpawnSpeed.value >= 0.1f))
        {
            ShowSpawnSpeed.text = "Spawn speed: VERY FAST"; //+ CarSpawnSpeed.ToString();
        }
    }
}
