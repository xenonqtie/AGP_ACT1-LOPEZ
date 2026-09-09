using UnityEngine;

public class CubeB : MonoBehaviour
{
    private float elapsed;

    void Update()
    {
        elapsed += Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x += 5f * Time.deltaTime;
        transform.position = pos;

        if (elapsed >= 5f)
        {
            Debug.Log($"{name}: {transform.position.x}");
            enabled = false;
        }
    }
}