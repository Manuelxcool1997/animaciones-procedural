using inSession;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    [SerializeField] private int meleeDamage = 1;
    [SerializeField] private float retreat_distance;
    [SerializeField] private float stop_distance;
    [SerializeField] private float speed;
    [SerializeField] private float damageDelay;
    [SerializeField] private float radio;
    [SerializeField] private bool playerDetected = false;
    [SerializeField] private LayerMask playerMask;

    private EnemyHealth health;
    private bool canDamage;
    [SerializeField]private Transform coyote;
    [SerializeField] private Transform baquir;
    void Start()
    {
        health = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDetected = Physics.CheckSphere(transform.position, radio, playerMask);
        if (playerDetected)
        {
            Debug.Log("Te vi");
            EnemyMovement();
        }
    }

    private void EnemyMovement()
    {
        if (GameObject.Find("Coyote"))
        {
            if (Vector3.Distance(transform.position, coyote.position) > stop_distance)
            {
                Vector3 targetPosition = new Vector3(coyote.position.x, transform.position.y, coyote.position.z);
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
            else if (Vector3.Distance(transform.position, coyote.position) < stop_distance && Vector3.Distance(transform.position, coyote.position) > retreat_distance)
            {
                transform.position = this.transform.position;
            }
        }
       else if (GameObject.Find("Baquir"))
        {
            if (Vector3.Distance(transform.position, baquir.position) > stop_distance)
            {
                Vector3 targetPosition = new Vector3(baquir.position.x, transform.position.y, baquir.position.z);
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
            else if (Vector3.Distance(transform.position, baquir.position) < stop_distance && Vector3.Distance(transform.position, baquir.position) > retreat_distance)
            {
                transform.position = this.transform.position;
            }
        }
    }
   

    private IEnumerator DamageDelay()
    {
        yield return new WaitForSeconds(damageDelay);
        canDamage = true;
    }
}
