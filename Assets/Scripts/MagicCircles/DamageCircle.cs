using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCircle : MonoBehaviour, ICircle
{
    private int damageAmount;

    public float Amount { get; set; }
    public StatType Type { get; set; }

    public void Despawn()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }

    public float GetCalculatedAmount()
    {
        return Amount * -1;
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void StartLifeCycle()
    {
        CircleLifeCycle circleBehaviour = new DamageCircleLifeCycle();
        
        StartCoroutine(circleBehaviour.Activate(this));
    }



    private void Start()
    {
        Amount = 7;
        Type = StatType.Health;
    }

    
}
