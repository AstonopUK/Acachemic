using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInteractHit : MonoBehaviour
{

    [SerializeField] GameObject gameSpawn;
    [SerializeField] string objTag;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == objTag)
        {

            Instantiate(gameSpawn, collision.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }

    }

}
