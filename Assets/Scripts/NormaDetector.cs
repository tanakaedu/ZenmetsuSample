using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// ノルマを持ったオブジェクトの一団を管理するスクリプト
/// </summary>
public class NormaDetector : MonoBehaviour
{
    [Tooltip("管理するノルマオブジェクトのインスタンス"), SerializeField]
    DetectedObject[] detectedObjects = default;
    [Tooltip("ノルマが全て達成された時に実行するイベント"), SerializeField]
    UnityEvent allClearEvent = new UnityEvent();

    List<DetectedObject> leftDetectedObjects;

    void Start()
    {
        leftDetectedObjects = new List<DetectedObject>(detectedObjects);
        for (int i=0;i<detectedObjects.Length;i++)
        {
            detectedObjects[i].SetDetector(this);
        }
    }

    /// <summary>
    /// ノルマを達成したオブジェクトが、自分のインスタンスを渡して呼び出す。
    /// </summary>
    /// <param name="source">ノルマを達成したオブジェクトのインスタンス</param>
    public void Done(DetectedObject source)
    {
        // 含まれていたsourceを削除
        leftDetectedObjects.Remove(source);
        if (leftDetectedObjects.Count == 0)
        {
            allClearEvent.Invoke();
        }
    }
}
