using System;
using UnityEngine;

namespace BruLibrary
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class AssetPathAttribute : PropertyAttribute
    {
        public Type Type;


        public AssetPathAttribute(Type type)
        {
            Type = type;
        }
    }
}