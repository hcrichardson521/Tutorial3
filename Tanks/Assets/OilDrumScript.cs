using UnityEngine;
using System.Collections;

public class OilDrumScript : MonoBehaviour {

    public ParticleSystem ps;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Tank")
        {
            TankHealth targetHealth = other.GetComponent<TankHealth>();
                //;.GetComponent<TankHealth>();
            /*if (!targetHealth)
                continue;*/
            float damage = 10;
            targetHealth.TakeDamage(damage);
            ps.gameObject.transform.position = transform.position;
            ps.Emit(1000);
            Destroy(gameObject);
        }
    }
}
