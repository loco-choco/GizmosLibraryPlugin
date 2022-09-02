using UnityEngine;

public class ColliderGizmoExample : MonoBehaviour
{
    public void OnRenderObject()
    {
        GizmosAPI.SetDefaultMaterialPass();//Sets the default material for gizmos
        
		Collider col = gameObject.GetComponent<Collider>();
		
        //For drawing the collider bounding box, using the global reference frame is recommended
        GizmosAPI.DrawOnGlobalReference(() =>
        {
            GizmosAPI.DrawColliderBoundingBox(col, Color.yellow);
        });
        //While for the actual collider, to account for the rotation and the scale, you DrawWithReference
        GizmosAPI.DrawWithReference(transform, () =>
        {
            GizmosAPI.DrawCollider(col, Color.blue);
        });
    }
}