using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        var unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        var unityActivity = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
        var javaClass = new AndroidJavaClass("com.company.example.Test");
        javaClass.CallStatic("CallAndroid", unityActivity);
    }
}