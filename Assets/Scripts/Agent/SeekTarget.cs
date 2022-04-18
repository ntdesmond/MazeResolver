using UnityEngine;
using UnityEngine.AI;

namespace Agent
{
    public class SeekTarget : MonoBehaviour
    {
        public Transform target;

        private Vector3 _lastTargetPosition;

        private void Start()
        {
            var targetPosition = target.position;
            
            // Set the initial target for NavMeshAgent
            GetComponent<NavMeshAgent>().SetDestination(targetPosition);
            _lastTargetPosition = targetPosition;
        }
        
        private void Update()
        {
            var targetPosition = target.position;
            
            // Wait until the target position changes
            if (_lastTargetPosition == targetPosition)
            {
                return;
            }
            
            // Set the target for NavMeshAgent
            GetComponent<NavMeshAgent>().SetDestination(targetPosition);
            _lastTargetPosition = targetPosition;
        }
    }
}
