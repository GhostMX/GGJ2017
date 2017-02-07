using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarScript : MonoBehaviour {

    // Use this for initialization
    public void destroyThis()
    {
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        RockActivatedScript rock =  collision.GetComponent<RockActivatedScript>();
        if (rock != null)
        {
            rock.throwRock(this.transform.position);
        }
    }
}
