using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        var midPoint = (transform.position - Camera.main.transform.position).magnitude * 0.5f;

        transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);

    }
}
