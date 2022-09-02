using UnityEngine;

public class TransformGizmoExample : MonoBehaviour
{
    //This is one of the times GL stuff can be called and draw stuff
    //the other method is OnPostRender, but that one requires that is script is attached to the camera
    //while OnRenderObject can be attached to different objects
    public void OnRenderObject()
    {
        GizmosAPI.SetDefaultMaterialPass();//Sets the default material for gizmos
        //Draw world origin
        GizmosAPI.DrawOnGlobalReference(() =>
        {
            //You can call DrawAxis outside of DrawOnGlobalReference, but it is recommended to do it inside one
            //if you want the global reference frame, as this pushes and pops the identity transform matrix for you
            GizmosAPI.DrawAxis(0.25f, Color.green, Vector3.zero);
        });
        GizmosAPI.DrawAxis(0.25f, Color.red, Vector3.zero);

        GizmosAPI.DrawWithReference(transform, () =>
        {
            //If inside DrawWithReference it will draw as if it was a child of the transform,
            //so its position, rotation and scale will affect the final draw.
            //This is the recommended way to draw relative stuff like axis

            GLDraw.DrawAxis(0.25f, Color.green, Vector3.zero);
            //The head size scales with the transform scale, so 0.25f is more a 25%
        });

        //Simmilar to:
        //GizmosAPI.DrawOnGlobalReference(() =>
        //{
        //    GizmosAPI.DrawTransform(transform, 0.25f, Color.green);
        //});
        //But the headsize will not scale with the transform scale
    }
}