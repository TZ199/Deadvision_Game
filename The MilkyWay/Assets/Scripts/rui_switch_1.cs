using UnityEngine;

public class rui_switch_1 : MonoBehaviour
{
    public GameObject com;
    public GameObject sw;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Vector3 pos = new Vector3(com.transform.position.x,com.transform.position.y-1,transform.position.z);
            com.transform.position = pos;
        }
     

    }
}
