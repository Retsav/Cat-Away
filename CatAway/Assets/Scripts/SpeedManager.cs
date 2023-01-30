using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private ObjectSpawner objectSpawner;
    [SerializeField] private AnimationCurve speedCurve;
    [SerializeField] private int maxPoints;

    void Update()
    {
        SpeedIncreaseHandler();
    }

    private void SpeedIncreaseHandler()
    {
        var point = score.Points / maxPoints;
        var speedIntersection = speedCurve.Evaluate(point);
        objectSpawner.desiredSpeedOverride = speedIntersection;
    }
}
