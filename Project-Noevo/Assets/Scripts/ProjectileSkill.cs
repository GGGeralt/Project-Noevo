using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "New Projectile Ability")]
public class ProjectileSkill : Skill
{
    public GameObject projectile;
    public override void UseSkill()
    {
        Instantiate(projectile, Player.Instance.transform.position, Quaternion.identity);
        Debug.Log("Trying to use " + name);
    }
}
