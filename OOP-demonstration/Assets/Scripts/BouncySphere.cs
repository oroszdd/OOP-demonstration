using UnityEngine;

public class BouncySphere : BaseSphere
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void SetBouncyness()
    {
        gameObject.GetComponent<SphereCollider>().material.bounciness = 1.0f;
    }
}
