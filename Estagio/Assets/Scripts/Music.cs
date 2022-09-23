using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{
    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
}
