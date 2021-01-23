/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CollisionCheckMath
{
	// Nested types
	public struct Cylinder
	{
		// Fields
		public Vector3 pos;
		public float radius;
		public float height;
		public int basePosType;
	}

	public struct Capsule
	{
		// Fields
		public Vector3 pos;
		public float radius;
		public float height;
		public Vector3 up;
	}

	// Constructors
	public CollisionCheckMath();

	// Methods
	public static bool IsCollideWithCirleAndFan(Vector3 circleCenter, float circleRadius, Vector3 fanCenter, float fanRadius, Vector3 fanForward, float halfFanDegree, bool ignoreHeight);
	public static bool IsCollideWithCylinderAndFan(Cylinder cylinder, Vector3 fanCenter, float fanRadius, float fanHeight, Vector3 fanForward, float halfFanDegree);
	public static bool IsPointInInfiniteFan(Vector3 point, Vector3 fanCenter, Vector3 fanForward, float halfFanDegree);
	public static bool IsPointInFan(Vector3 point, Vector3 fanCenter, float fanRadius, Vector3 fanForward, float halfFanDegree);
	public static bool IsPointInCircle(Vector2 point, Vector2 circleCenter, float circleRadius);
	public static bool IsPointInRect(Vector3 point, float x, float y, float width, float height);
	public static bool IsPointInCube(Vector3 point, float x, float y, float z, float width, float height, float length);
	public static bool IsPointInUnRegularRect(Vector3 point, float degreeFromForward, float x, float y, float width, float height);
	public static bool OverlapSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);
	public static bool OverlapAABBs(Bounds b1, Bounds b2);
	public static bool OverlapSphereAABB(Vector3 center, float radius, Bounds bound);
	public static bool IsPointInShpere(Vector3 point, Vector3 center, float radius);
	public static bool IsPointInCylinder(Vector3 point, Cylinder cylinder, bool ignoreHeight = false);
	public static bool IsInDonut2D(Vector3 center, float insideRadius, float outsideRadius, Cylinder cylinder);
	public static bool IsPointInAABB(Bounds bound, Vector3 point);
	public static bool OverlapCapsules(Capsule c0, Capsule c1);
	private static float GetPointToLineSegmentSqrDistance(Vector3 p, Vector3 l_start, Vector3 l_end);
	private static float GetLineSegmentsSqrDistance(Vector3 l0_start, Vector3 l0_end, Vector3 l1_start, Vector3 l1_end);
}

