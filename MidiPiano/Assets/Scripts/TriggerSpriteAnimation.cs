using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpriteAnimation : MonoBehaviour
{
    public Animator animator;

    private void Awake()
    {
        animator = this.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNextAniByTrigger()
    {
        animator.SetTrigger("next");
    }
}
