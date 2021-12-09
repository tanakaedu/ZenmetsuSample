using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ノルマを持ったオブジェクト。
/// ノルマを達成したら、detectorInstance.Done()を呼び出す。
/// </summary>
public class DetectedObject : MonoBehaviour, IDetectedObject
{
    NormaDetector detectorInstance;

    public void SetDetector(NormaDetector detector)
    {
        detectorInstance = detector;
    }

    public void Done()
    {
        detectorInstance.Done(this);
    }
}
