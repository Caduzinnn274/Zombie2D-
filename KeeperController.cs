using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperControl : MonoBehaviour
{

    public Transform a;
    public Transform b;

    public Transform skin;

    public bool goRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(skin.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("KeeperAttack"))
        {
            return;
        }

        if(goRight ==  true)
        {

            skin.localScale = new Vector3(1, 1, 1);
            if(Vector2.Distance(transform.position, b.position) < 0.1f)
            {
                goRight = false;
            }
           transform.position =  Vector2.MoveTowards(transform.position, b.position, 5 * Time.deltaTime);
        }
        else
        {
            skin.localScale = new Vector3(-1, 1, 1);
            if (Vector2.Distance(transform.position, a.position) < 0.1f)
            {
                goRight = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, a.position, 5 * Time.deltaTime);

        }
        
        
    }
}
