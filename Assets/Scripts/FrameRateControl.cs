using UnityEngine;

public class FrameRateControl : MonoBehaviour
{
    [SerializeField] private int targetFPS = 30;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFPS;
    }
}