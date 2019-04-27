using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmScript : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        if (vertical > 0)
        {
            anim.SetInteger("direction", 1);
        }
        else if (vertical == 0)
        {
            anim.SetInteger("direction", 0);
        }
    }
}
