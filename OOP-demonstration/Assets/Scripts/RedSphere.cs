using UnityEngine;

// INHERITANCE
public class RedSphere : BaseSphere
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

    // POLIMORPHISM
    protected override void SetColor()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
