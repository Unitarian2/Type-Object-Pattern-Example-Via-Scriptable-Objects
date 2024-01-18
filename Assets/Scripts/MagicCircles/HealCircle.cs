using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCircle : MonoBehaviour, ICircle
{
    private int healAmount;
    
    public float Amount { get; set; }
    public StatType Type { get; set; }

    public void Despawn()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }

    public float GetCalculatedAmount()
    {
        return Amount;
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

    public void StartLifeCycle()
    {
        CircleLifeCycle circleBehaviour = new HealCircleLifeCycle();
        
        StartCoroutine(circleBehaviour.Activate(this));
    }

    private void Start()
    {
        Amount = 5;
        Type = StatType.Health;
    }
}
