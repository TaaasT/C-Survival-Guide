using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    int Health { get; set; }

    void Damage(int damageAmount);

}

public class AbstractPlayer : MonoBehaviour, IDamagable
{
    int IDamagable.Health { get; set; }

    void IDamagable.Damage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }
}

public class Enemy : MonoBehaviour, IDamagable
{
    public int Health { get; set; }

    public void Damage(int damageAmount)
    {

    }

}
    