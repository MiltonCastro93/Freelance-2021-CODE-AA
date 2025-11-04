using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
    private Vector3 posRelative = Vector3.zero;
    public Animator anim;
    private Vector3 _posBoneHand;
    public GameObject myParticules;

    private void Awake() {
        anim.GetComponent<Animator>();
        posRelative = myParticules.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update() {
        myParticules.transform.position = _posBoneHand;
    }

    private void LateUpdate() {
        _posBoneHand = anim.GetBoneTransform(HumanBodyBones.LeftHand).position + posRelative - new Vector3(0.45f,0.2f,1.9f);
    }

}
