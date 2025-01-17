using UnityEngine;
using UnityEngine.AI;

namespace LostInTheVillage.Storyline.Wine
{
    public class GoToWine : MonoBehaviour
    {
        [SerializeField] private Transform movePositionTransforms;
        [SerializeField] private Transform movePositionTransforms2;

        private Animator animator;
        private NavMeshAgent navMeshAgent;

        private bool first;
        private bool second;

        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
        }

        private void Start()
        {
            first = false;
            second = false;
        }
        public void MoveToDestination()
        {
            first = true;
            SetDestination();
            animator.SetBool("is_walk", true);
        }
        public void MoveToDestination2()
        {
            second = true;
            SetDestination2();
            animator.SetBool("is_walk", true);
        }

        private void Update()
        {
            if (first)
            {
                float distance = Vector3.Distance(movePositionTransforms.position, transform.position);
                if (distance < 1f)
                {
                    animator.SetBool("is_walk", false);
                    first = false;
                }
            }
            else if (second)
            {
                float distance = Vector3.Distance(movePositionTransforms2.position, transform.position);
                if (distance < 1f)
                {
                    animator.SetBool("is_walk", false);
                    second = false;
                }
            }
        }

        private void SetDestination()
        {
            navMeshAgent.destination = movePositionTransforms.position;
        }
        private void SetDestination2()
        {
            navMeshAgent.destination = movePositionTransforms2.position;
        }
    }
}