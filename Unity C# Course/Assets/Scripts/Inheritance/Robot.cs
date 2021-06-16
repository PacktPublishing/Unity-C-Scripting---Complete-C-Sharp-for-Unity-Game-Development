using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//IS A
public class Robot : Enemy {

    public bool attacking = false;

    private void Update()
    {
        if (attacking)
        {
            Attack();
            //base.Attack();
        }
    }

    //void Attack()
    //{
    //    print(" Dragon Attack");
    //}
}
