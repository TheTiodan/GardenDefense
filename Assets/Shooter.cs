﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Projectile projectile;
    [SerializeField] GameObject gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;
    GameObject projectileParent;

    const string PROJECTILE_PARENT_NAME = "Projectiles";


    private void Start()
    {
        CreateProjectileParent();
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }

    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }
    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0 )
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Fire()
    {
        Projectile newprojectile = Instantiate(projectile, gun.transform.position, transform.rotation) as Projectile;
        newprojectile.transform.parent = projectileParent.transform;
    }


}
