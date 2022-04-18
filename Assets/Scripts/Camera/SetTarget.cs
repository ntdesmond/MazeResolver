using UnityEngine;

namespace Camera
{
    public class SetTarget : MonoBehaviour
    {
        public Transform targetObject;

        private UnityEngine.Camera _camera;

        private void Awake()
        {
            _camera = GetComponent<UnityEngine.Camera>();
        }

        // Update is called once per frame
        private void Update()
        {
            // Wait for mouse click
            if (!Input.GetMouseButtonDown(0))
            {
                return;
            }
        
            // Cast a ray to mouse position
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out var hit))
            {
                return;
            }

            // Move target
            var newPos = hit.point;
            newPos.y += targetObject.lossyScale.y / 2;
            targetObject.position = newPos;
        }
    }
}
