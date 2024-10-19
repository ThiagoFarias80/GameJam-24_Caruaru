using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleBehavior : MonoBehaviour
{

    private void OnTriggerEnter(Collider colissor)
    {
        if (colissor.TryGetComponent(out CharacterMediator CharacterMediator))
        {
            CharacterMediator.TakeDamage();
        }


    }
}
