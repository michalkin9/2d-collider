using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boarderDestoruy : MonoBehaviour
{
        [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
        [SerializeField] string triggeringTag;
            [SerializeField] string triggeringTag2;
    private void OnTriggerEnter2D(Collider2D other)
        {
        }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(other.gameObject);
        }

        if(other.tag == triggeringTag2 && enabled)
        {

            float y = other.transform.position.y;

            if (other.transform.position.x >= 9f)
            {
                other.transform.position = new Vector3(other.transform.position.x * (-1), other.transform.position.y, 0);

            }
            else if (other.transform.position.x <= -9f)
            {

                other.transform.position = new Vector3(other.transform.position.x * (-1), other.transform.position.y, 0);
            }
            
            if (other.transform.position.y <= -5f)
            {
                other.transform.position = new Vector3(other.transform.position.x, (-1)*other.transform.position.y , 0);
            }
        }
    }


}