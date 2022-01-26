using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using System.Reflection;
using Installers;

namespace Installers.Editor
{
    [CustomEditor(typeof(CompositeSetup))]
    public class CompositeSetupEditor : UnityEditor.Editor
    {
        private SerializedProperty setupsProperty;

        private void OnEnable()
        {
            if (target != null)
            {
                setupsProperty = serializedObject.FindProperty("setups");
            }
        }

        public override void OnInspectorGUI()
        {
            if (target != null)
            {
                EditorGUILayout.PropertyField(setupsProperty);
            }
        }
    }
}