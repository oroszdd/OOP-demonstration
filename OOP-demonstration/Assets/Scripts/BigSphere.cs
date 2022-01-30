public class BigSphere : BaseSphere
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

    protected override void SetSize()
    {
        gameObject.transform.localScale *= 3.0f;
    }
}
