using UnityEngine;
using System.Collections;

public class TBoneController : MonoBehaviour
{
    float speed = 10;
    float lifeTime;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1 * speed) * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > 2)
        {
            Destroy(this.gameObject);
        }
    }
}
