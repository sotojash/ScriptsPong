using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidadMovimiento;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * velocidadMovimiento;
    }

}
