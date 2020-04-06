using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractInfo : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;

    //forces inheritance on other scripts
    public abstract void Attack();
    
    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}


public class MossGiant : AbstractInfo
{
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }
    public override void Die()
    {
        // costom particles
        base.Die();
    }

}