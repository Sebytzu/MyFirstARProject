using UnityEngine;

public class CactusInteract : MonoBehaviour
{
    public Transform otherCactus;
    public float attackDistance = 0.25f;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (otherCactus != null)
        {
            float distance = Vector3.Distance(transform.position, otherCactus.position);

            if (distance <= attackDistance)
            {
                animator.SetBool("isAttacking", true);
            }
            else
            {
                animator.SetBool("isAttacking", false);
            }
        }
    }
}