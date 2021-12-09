using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// クリックがノルマのオブジェクト
/// </summary>
public class ClickDestroyer : MonoBehaviour
{
    /// <summary>
    ///  クリックしたら、ノルマ完了を報告、自分を消滅させる。
    /// </summary>
    void OnMouseDown()
    {
        GetComponent<IDetectedObject>().Done();
        Destroy(gameObject);
    }
}
