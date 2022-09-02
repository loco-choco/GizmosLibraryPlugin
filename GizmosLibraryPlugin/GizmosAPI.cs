using System;
using UnityEngine;

namespace GizmosLibrary
{

	public static class GizmosAPI
	{
		//GLHelper
		public static Material GetDefaultMaterial() => GLHelper.GetDefaultMaterial();
		public static void SetDefaultMaterialPass(int pass = 0) => GLHelper.SetDefaultMaterialPass(pass);
		public static void DrawWithReference(Transform reference, Action drawMethod) => GLHelper.DrawWithReference(reference, drawMethod);
		public static void DrawOnGlobalReference(Action drawMethod) => GLHelper.DrawOnGlobalReference(drawMethod);
		public static void DrawWithOrthoProjection(Action drawMethod) => GLHelper.DrawWithOrthoProjection(drawMethod);
		public static void DrawAxis(float headSize, Color color, Vector3 offset) => GLHelper.DrawAxis(headSize, color, offset);
		public static void DrawTransform(Transform transform, float headSize, Color color) => GLHelper.DrawTransform(transform, headSize, color);
		public static void DrawCollider(Collider collider, Color color) => GLHelper.DrawCollider(collider, color);
		public static void DrawColliderBoundingBox(Collider collider, Color color) => GLHelper.DrawColliderBoundingBox(collider, color);
		//GLDraw
		public static void DrawSimpleWireframeCube(Vector3 offset, Color color) => GLDraw.SimpleWireframeCube(offset, color);
		public static void DrawWireframeCube(Vector3 foward, Vector3 up, Vector3 right, Vector3 offset, Color color) => GLDraw.WireframeCube(foward, up, right, offset, color);
		public static void DrawWireframeCircle(float radius, Vector3 normal, Vector3 up, Vector3 offset, Color color, int resolution = 3, float startAngle = 0f, float endAngle = 2f * Mathf.PI, bool isWholeCircle = true) 
			=> GLDraw.WireframeCircle(radius, normal, up, offset, color, resolution, startAngle, endAngle, isWholeCircle);
		public static void DrawSimpleWireframeSphere(float radius, Vector3 offset, Color color, int resolution)
			=> GLDraw.SimpleWireframeSphere(radius, offset, color, resolution);
		public static void DrawWireframeSphere(float radius, Vector3 offset, Vector3 foward, Vector3 up, Color color, int resolution = 3)
			=> GLDraw.WireframeSphere(radius, offset, foward, up, color, resolution);
		public static void DrawWireframeHemisphere(float radius, Vector3 offset, Vector3 foward, Vector3 up, Color color, int resolution = 3)
			=> GLDraw.WireframeHemisphere(radius, offset, foward, up, color, resolution);
		public static void DrawWireframeCapsule(float radius, Vector3 startPoint, Vector3 endPoint, Color color, int resolution = 3)
			=> GLDraw.WireframeCapsule(radius, startPoint, endPoint, color, resolution);
		public static void DrawSimpleWireframeCapsule(float radius, float height, Vector3 up, Vector3 offset, Color color, int resolution = 3)
			=> GLDraw.SimpleWireframeCapsule(radius, height, up, offset, color, resolution);
		public static void DrawWireframeCone(float coneRadiusStart, float coneRadiusEnd, Vector3 coneStart, Vector3 coneEnd, Color color, int resolution = 3)
			=> GLDraw.WireframeCone(coneRadiusStart,coneRadiusEnd,coneStart,coneEnd,color,resolution);
		public static void DrawVector(Vector3 vector, float headSize, Vector3 offset, Color color) => GLDraw.Vector(vector, headSize, offset, color);
	}
}
