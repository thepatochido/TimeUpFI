using UnityEngine;

public class ScrollerFondo : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float velocidadScroll = 0.5f;
    private float offset;
    private Material material1;
    // Start is called before the first frame update
    void Start()
    {
        material1 = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * velocidadScroll) / 10f;
        material1.SetTextureOffset("_MainTex",new Vector2 (offset,0));

    }
}
