using UnityEngine;

public class CollisionCheckMath
{
	public struct Cylinder
	{
		public Vector3 pos;

		public float radius;

		public float height;

		public int basePosType;
	}

	public struct Capsule
	{
		public Vector3 pos;

		public float radius;

		public float height;

		public Vector3 up;
	}

	public static bool IsCollideWithCirleAndFan(Vector3 circleCenter, float circleRadius, Vector3 fanCenter, float fanRadius, Vector3 fanForward, float halfFanDegree, bool ignoreHeight)
	{
		return default(bool);
	}

	public static bool IsCollideWithCylinderAndFan(Cylinder cylinder, Vector3 fanCenter, float fanRadius, float fanHeight, Vector3 fanForward, float halfFanDegree)
	{
		return default(bool);
	}

	public static bool IsCollideWithCylinderAndFan02(Cylinder cylinder, Vector3 fanCenter, float fanRadius, float fanHeight, Vector3 fanForward, float halfFanDegree)
	{
		return default(bool);
	}

	public static bool IsPointInInfiniteFan(Vector3 point, Vector3 fanCenter, Vector3 fanForward, float halfFanDegree)
	{
		return default(bool);
	}

	public static bool IsPointInFan(Vector3 point, Vector3 fanCenter, float fanRadius, Vector3 fanForward, float halfFanDegree)
	{
		return default(bool);
	}

	public static bool IsPointInCircle(Vector2 point, Vector2 circleCenter, float circleRadius)
	{
		return default(bool);
	}

	public static bool IsPointInRect(Vector3 point, float x, float y, float width, float height)
	{
		return default(bool);
	}

	public static bool IsPointInCube(Vector3 point, float x, float y, float z, float width, float height, float length)
	{
		return default(bool);
	}

	public static bool IsPointInUnRegularRect(Vector3 point, float degreeFromForward, float x, float y, float width, float height)
	{
		return default(bool);
	}

	public static bool OverlapSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2)
	{
		return default(bool);
	}

	public static bool OverlapAABBs(Bounds b1, Bounds b2)
	{
		return default(bool);
	}

	public static bool OverlapSphereAABB(Vector3 center, float radius, Bounds bound)
	{
		return default(bool);
	}

	public static bool IsPointInShpere(Vector3 point, Vector3 center, float radius)
	{
		return default(bool);
	}

	public static bool IsPointInCylinder(Vector3 point, Cylinder cylinder, bool ignoreHeight = false)
	{
		return default(bool);
	}

	public static bool IsInDonut2D(Vector3 center, float insideRadius, float outsideRadius, Cylinder cylinder)
	{
		return default(bool);
	}

	public static bool IsPointInAABB(Bounds bound, Vector3 point)
	{
		return default(bool);
	}

	public static bool OverlapCapsules(Capsule c0, Capsule c1)
	{
		return default(bool);
	}

	private static float GetPointToLineSegmentSqrDistance(Vector3 p, Vector3 l_start, Vector3 l_end)
	{
		return default(float);
	}

	private static float GetLineSegmentsSqrDistance(Vector3 l0_start, Vector3 l0_end, Vector3 l1_start, Vector3 l1_end)
	{
		return default(float);
	}
}
