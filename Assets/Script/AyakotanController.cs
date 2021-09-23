using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyakotanController : MonoBehaviour
{
    [SerializeField, Tooltip("移動スピード")]
    private int moveSpeed;

    [SerializeField]
    private Animator playerAnim;

    public Rigidbody2D rb;


    [SerializeField]
    private Animator weaponAnim;

    [System.NonSerialized]
    public int currentHealth;
    public int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        //GameManager.instance.UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;

        if (rb.velocity != Vector2.zero)
        {
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                if (Input.GetAxisRaw("Horizontal") > 0)
                {
                    playerAnim.SetFloat("X", 1f);
                    playerAnim.SetFloat("Y", 0);

                    weaponAnim.SetFloat("X", 1f);
                    weaponAnim.SetFloat("Y", 0);
                }
                else
                {
                    playerAnim.SetFloat("X", -1f);
                    playerAnim.SetFloat("Y", 0);

                    weaponAnim.SetFloat("X", -1f);
                    weaponAnim.SetFloat("Y", 0);
                }
            }
            else if (Input.GetAxisRaw("Vertical") > 0)// right
            {
                playerAnim.SetFloat("X", 0);
                playerAnim.SetFloat("Y", 1);

                weaponAnim.SetFloat("X", 0);
                weaponAnim.SetFloat("Y", 1);
            }
            else if (Input.GetAxisRaw("Vertical") < 0)//left
            {
                playerAnim.SetFloat("X", 0);
                playerAnim.SetFloat("Y", -1);

                weaponAnim.SetFloat("X", 0);
                weaponAnim.SetFloat("Y", -1);
            }                                        
        }

        if (Input.GetMouseButtonDown(0))
        {
            weaponAnim.SetTrigger("Attack");
        }
    }
}
