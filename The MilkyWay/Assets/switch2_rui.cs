using UnityEngine;

public class switch2_rui : MonoBehaviour
{
    SpriteRenderer platformColor;
    public GameObject platform;
    public PolygonCollider2D pc;
    public int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 1;
        pc = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player"&&i==1)
        {
            platform.GetComponent<BoxCollider2D>().enabled = true;
            foreach (Transform child in platform.transform)
            {
                platformColor = child.GetComponent<SpriteRenderer>();
                platformColor.color = new Color(platformColor.color.r, platformColor.color.g, platformColor.color.b, 1);

            }
            i = 0;
        }
        else
        {
            platform.GetComponent<BoxCollider2D>().enabled = false;
            foreach (Transform child in platform.transform)
            {
                platformColor = child.GetComponent<SpriteRenderer>();
                platformColor.color = new Color(platformColor.color.r, platformColor.color.g, platformColor.color.b, 0.3f);

            }
            i = 1;
        }
    }
}
