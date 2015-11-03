using UnityEngine;

namespace Assets.Scripts.Camara
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform Target;
        public float Smoothing = 5f;
        private Vector3 offset;

        private void Start()
        {
            offset = transform.position - Target.transform.position;
        }

        private void FixedUpdate()
        {
            Vector3 targetCamPos = Target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetCamPos, Smoothing*Time.deltaTime);
        }
    }
}
