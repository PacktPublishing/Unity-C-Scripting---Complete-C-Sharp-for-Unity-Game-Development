using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dragon : MonoBehaviour {

    private void Start()
    {
        Dragon dragon = new Dragon();
        dragon.Attack();

        Dragon dragon2 = new BlueDragon();
        dragon2.Attack();

        Dragon dragon3 = new RedDragon();
        dragon3.Attack();
    }

    public virtual void Attack()
    {
        print("Dragon Attack");
    }

} //End of dragon class

public class BlueDragon : Dragon
{


    public override void Attack()
    {
        print(" Blue Dragon Attack");
    }
}

public class RedDragon : Dragon
{

    public override void Attack()
    {
        print("Red Dragon Attack");
    }
}



