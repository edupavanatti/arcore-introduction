using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConsumer : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            collision.gameObject.SetActive(false);
            Slithering s = GetComponentInParent<Slithering>();

            if (s != null)
            {
                s.AddBodyPart();
            }
        }
    }
}
