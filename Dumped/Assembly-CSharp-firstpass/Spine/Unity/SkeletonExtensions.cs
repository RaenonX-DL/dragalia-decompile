/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public static class SkeletonExtensions
	{
		// Fields
		private const float ByteToFloat = 0.003921569f;
	
		// Extension methods
		public static Color GetColor(this Skeleton s);
		public static Color GetColor(this RegionAttachment a);
		public static Color GetColor(this MeshAttachment a);
		public static Color GetColor(this Slot s);
		public static Color GetColorTintBlack(this Slot s);
		public static void SetColor(this Skeleton skeleton, Color color);
		public static void SetColor(this Skeleton skeleton, Color32 color);
		public static void SetColor(this Slot slot, Color color);
		public static void SetColor(this Slot slot, Color32 color);
		public static void SetColor(this RegionAttachment attachment, Color color);
		public static void SetColor(this RegionAttachment attachment, Color32 color);
		public static void SetColor(this MeshAttachment attachment, Color color);
		public static void SetColor(this MeshAttachment attachment, Color32 color);
		public static void SetPosition(this Bone bone, Vector2 position);
		public static void SetPosition(this Bone bone, Vector3 position);
		public static Vector2 GetLocalPosition(this Bone bone);
		public static Vector2 GetSkeletonSpacePosition(this Bone bone);
		public static Vector2 GetSkeletonSpacePosition(this Bone bone, Vector2 boneLocal);
		public static Vector3 GetWorldPosition(this Bone bone, Transform spineGameObjectTransform);
		public static Vector3 GetWorldPosition(this Bone bone, Transform spineGameObjectTransform, float positionScale);
		public static Quaternion GetQuaternion(this Bone bone);
		public static Quaternion GetLocalQuaternion(this Bone bone);
		public static Matrix4x4 GetMatrix4x4(this Bone bone);
		public static void GetWorldToLocalMatrix(this Bone bone, out float ia, out float ib, out float ic, out float id);
		public static Vector2 WorldToLocal(this Bone bone, Vector2 worldPosition);
		public static Vector2 SetPositionSkeletonSpace(this Bone bone, Vector2 skeletonSpacePosition);
		public static Material GetMaterial(this Attachment a);
		public static Vector2[] GetLocalVertices(this VertexAttachment va, Slot slot, Vector2[] buffer);
		public static Vector2[] GetWorldVertices(this VertexAttachment a, Slot slot, Vector2[] buffer);
		public static Vector3 GetWorldPosition(this PointAttachment attachment, Slot slot, Transform spineGameObjectTransform);
		public static Vector3 GetWorldPosition(this PointAttachment attachment, Bone bone, Transform spineGameObjectTransform);
	}
}
