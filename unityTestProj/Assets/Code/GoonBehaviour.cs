using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Goon
{
    public class GoonBehaviour : MonoBehaviour
    {

        public Action OnAwake;
        public Action OnStart;
        public Action OnOnEnable;
        public Action OnOnDisable;
        public Action OnUpdate;

        #region MonoBehaviour methods
        protected virtual void Awake()
        {
            Debug.Log("base");

            //ReflectDerivedClassMethods();
            ReflectInitComponents();

            if (OnAwake != null)
            {
                OnAwake();
            }
        }
        #endregion

        #region Reflection
        private void ReflectInitComponents()
        {
            foreach (FieldInfo field in this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                foreach (Attribute attribute in field.GetCustomAttributes(true))
                {
                    if (attribute.GetType() == typeof(InitComponentAttribute))
                    {
                        Component component = GetComponent(field.FieldType.Name);
                        field.SetValue(this, component);
                    }
                }
            }
        }
        #endregion

    }
}
