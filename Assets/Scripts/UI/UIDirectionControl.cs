﻿using UnityEngine;
using UnityEngine.Serialization;

namespace Complete
{
    /// <summary>
    /// Used to make sure world space UI elements such as the health bar face the correct direction.
    /// </summary>
    public class UIDirectionControl : MonoBehaviour
    {
        [FormerlySerializedAsAttribute("m_UseRelativeRotation")]
        public bool _useRelativeRotation = true;        // Use relative rotation should be used for this gameobject?

        private Quaternion m_RelativeRotation;          // The local rotatation at the start of the scene.

        private void Start()
        {
            m_RelativeRotation = transform.parent.localRotation;
        }

        private void Update()
        {
            if (_useRelativeRotation)
                transform.rotation = m_RelativeRotation;
        }
    }
}