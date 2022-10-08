using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public GameObject graphDrawer;
    public float time = 0.0f;
    public Vector3 position;
    // Start is called before the first frame update

    private void Awake()
    {
        graphDrawer.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        Vector3 position = graphDrawer.transform.position;
        position += this.LorenzDelta(dt, position.x, position.y, position.z);
        graphDrawer.transform.position = position;
    }
    public Vector3 LorenzDelta(float dt, float x, float y, float z, float s = 10f, float r = 28f, float b = 8 / 3)
    {
        Vector3 delta;
        delta.x = s * (y - x) * dt;
        delta.y = (r * x - y - x * z) * dt;
        delta.z = (x * y - b * z) * dt;
        return delta;
    }
}
