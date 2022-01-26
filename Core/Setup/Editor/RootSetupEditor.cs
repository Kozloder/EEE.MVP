using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Installers
{
    [CustomEditor(typeof(RootSetup))]
    public class RootSetupEditor : UnityEditor.Editor
    {
        private SerializedProperty setupsProperty;

        public void OnEnable()
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

                if (GUILayout.Button("Show Tree"))
                {
                    var tree = Util.TreeOfSetups(target as RootSetup);
                    Debug.Log(tree);
                }
            }
        }
    }
}