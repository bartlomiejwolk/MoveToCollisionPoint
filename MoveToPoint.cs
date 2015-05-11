using UnityEngine;
using System.Collections;

namespace OneDayGame {

    public class MoveToPoint : MonoBehaviour {

        /// Offset hit position forward/backward.
        [SerializeField]
        private float _offset;

        [SerializeField]
        private Transform targetTransform;

        public void MoveToHitPoint(Vector3 hitPoint) {

                targetTransform.position = hitPoint
                    + (hitPoint- targetTransform.position).normalized * _offset;
            }
        }
}
