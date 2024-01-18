using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCircle : BaseCircle, ICircle
{
    public float Amount { get; set; }
    public StatType Type { get; set; }

    public float GetCalculatedAmount()
    {
        return Amount * -1;
    }

    public void StartLifeCycle()
    {
        CircleLifeCycle circleBehaviour = new DamageCircleLifeCycle();
        
        StartCoroutine(circleBehaviour.Activate(this));
    }

    private void Start()
    {
        Amount = m_MagicCircleDataSO.amount;
        Type = m_MagicCircleDataSO.type;
    }

    
}
