using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCircleLifeCycle : CircleLifeCycle
{
    public override ICircle CircleRef { get; set; }
    public override IEnumerator Activate(ICircle circleRef)
    {
        this.CircleRef = circleRef;
        SpawnUp();
        yield return new WaitForSeconds(15);
        Shrink();
    }
}
