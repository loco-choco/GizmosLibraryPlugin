using UnityEngine;

namespace GizmosLibrary
{
    //From https://math.stackexchange.com/questions/511370/how-to-rotate-one-vector-about-another
    public static class Vector3MathUtils
    {
        public static void GetParalelAndPerpendicularComponent(Vector3 axis, Vector3 v, out Vector3 paralel, out Vector3 perpendicular) 
        {
            paralel = Vector3.Dot(v, axis) * axis / axis.magnitude;
            perpendicular = v - paralel;
        }
        public static Vector3 GetRotationVector(Vector3 axis, Vector3 perpendicularComponent)
        {
            return Vector3.Cross(axis, perpendicularComponent);
        }
        public static Vector3 GetRotatedVectorComponent (Vector3 rotationVector, Vector3 perpendicularComponent, float angle)
        {
            float x1 = Mathf.Cos(angle) / perpendicularComponent.sqrMagnitude;
            float x2 = Mathf.Sin(angle);

            return perpendicularComponent.sqrMagnitude * (x1 * perpendicularComponent + x2 * rotationVector);
        }

        //From https://codereview.stackexchange.com/questions/43928/algorithm-to-get-an-arbitrary-perpendicular-vector
        public static Vector3 GetArbitraryPerpendicularVector(Vector3 v) 
        {
            if (v.magnitude == 0f)
            {
                return Vector3.forward;
            }
            Vector3 firstAttempt = Vector3.Cross(v, Vector3.forward);
            if (firstAttempt.magnitude != 0f)
            {
                return firstAttempt.normalized;
            }
            else 
            {
                return Vector3.Cross(v, Vector3.up).normalized;
            }
        }
    }
}
