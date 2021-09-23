using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    Rigidbody2D playerrigid2D;
    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerrigid2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Rotate(0, 0, -10 * rotateSpeed);
        //}
        float h = Input.GetAxis("Horizontal") * rotateSpeed;
        float v = Input.GetAxis("Vertical") * rotateSpeed;
        transform.Rotate(0, 0, -h * rotateSpeed);
        playerrigid2D.AddForce(transform.right * moveSpeed * -h);
    }
}
