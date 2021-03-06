﻿using System.Collections;
using UnityEngine;

namespace MoveToCollisionPointEx {

    public class MoveToCollisionPoint : MonoBehaviour {

        #region CONSTANTS

        public const string Extension = "MoveToCollisionPoint";
        public const string Version = "v0.1.1";

        #endregion CONSTANTS

        #region INSPECTOR FIELDS

        [SerializeField]
        private string description = "Description";

        /// <summary>
        /// Offset hit position forward/backward.
        /// </summary>
        [SerializeField]
        private float offset;

        [SerializeField]
        private Transform targetTransform;

        #endregion INSPECTOR FIELDS

        #region PROPERTIES

        public string Description {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Offset hit position forward/backward.
        /// </summary>
        public float Offset {
            get { return offset; }
            set { offset = value; }
        }

        public Transform TargetTransform {
            get { return targetTransform; }
            set { targetTransform = value; }
        }

        #endregion PROPERTIES

        #region METHODS

        public void MoveToHitPoint(RaycastHit hitInfo) {
            if (TargetTransform == null) return;

            TargetTransform.position = hitInfo.point
                + (hitInfo.point - TargetTransform.position).normalized
                * Offset;
        }

        #endregion METHODS
    }

}