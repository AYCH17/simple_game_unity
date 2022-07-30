
using UnityEngine;

public class CamFollowNija : MonoBehaviour
{
    public Transform Ninja;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - Ninja.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ninja.position + offset;
    }
}
