using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyefollowCode : MonoBehaviour
{
    /*Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2 (0f, 0f);

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }

    */
   


    void Update()
    {
        Vector3 targetDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = (Mathf.Atan2(targetDir.y, targetDir.x)*Mathf.Rad2Deg)-90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
