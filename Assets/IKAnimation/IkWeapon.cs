using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkWeapon : MonoBehaviour {
    public Animator anim;
    public GameObject weapon;
    private Vector3 posHand = Vector3.zero;
    private Quaternion rotHand = Quaternion.identity;

    private void Update() {
        posHand = anim.GetBoneTransform(HumanBodyBones.LeftHand).position;
        rotHand = anim.GetBoneTransform(HumanBodyBones.LeftHand).rotation;
    }

    private void LateUpdate() {
        weapon.transform.position = posHand;
        weapon.transform.rotation = rotHand;
    }

}
