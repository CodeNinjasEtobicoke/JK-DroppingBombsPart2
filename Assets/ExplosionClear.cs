using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionClear : MonoBehaviour
{
    private ParticleSystem particalSmoke;
    // Start is called before the first frame update
   public void Awake()
    {
        particalSmoke = gameObject.GetComponentInChildren<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!particalSmoke.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
