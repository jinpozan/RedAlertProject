using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRifle : IWeapon {
    public override void Fire( Vector3 targetPosition )
    {
        Debug.Log("播放特效 播放声音 Rifle ...");
    }
}
