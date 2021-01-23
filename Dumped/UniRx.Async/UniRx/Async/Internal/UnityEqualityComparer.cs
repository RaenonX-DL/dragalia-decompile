/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal static class UnityEqualityComparer
	{
		// Fields
		public static readonly IEqualityComparer<Vector2> Vector2;
		public static readonly IEqualityComparer<Vector3> Vector3;
		public static readonly IEqualityComparer<Vector4> Vector4;
		public static readonly IEqualityComparer<Color> Color;
		public static readonly IEqualityComparer<Color32> Color32;
		public static readonly IEqualityComparer<Rect> Rect;
		public static readonly IEqualityComparer<Bounds> Bounds;
		public static readonly IEqualityComparer<Quaternion> Quaternion;
		private static readonly RuntimeTypeHandle vector2Type;
		private static readonly RuntimeTypeHandle vector3Type;
		private static readonly RuntimeTypeHandle vector4Type;
		private static readonly RuntimeTypeHandle colorType;
		private static readonly RuntimeTypeHandle color32Type;
		private static readonly RuntimeTypeHandle rectType;
		private static readonly RuntimeTypeHandle boundsType;
		private static readonly RuntimeTypeHandle quaternionType;
		public static readonly IEqualityComparer<Vector2Int> Vector2Int;
		public static readonly IEqualityComparer<Vector3Int> Vector3Int;
		public static readonly IEqualityComparer<RangeInt> RangeInt;
		public static readonly IEqualityComparer<RectInt> RectInt;
		public static readonly IEqualityComparer<BoundsInt> BoundsInt;
		private static readonly RuntimeTypeHandle vector2IntType;
		private static readonly RuntimeTypeHandle vector3IntType;
		private static readonly RuntimeTypeHandle rangeIntType;
		private static readonly RuntimeTypeHandle rectIntType;
		private static readonly RuntimeTypeHandle boundsIntType;
	
		// Nested types
		private static class Cache<T>
		{
			// Fields
			public static readonly IEqualityComparer<T> Comparer;
	
			// Constructors
			static Cache();
		}
	
		private sealed class Vector2EqualityComparer : IEqualityComparer<Vector2>
		{
			// Constructors
			public Vector2EqualityComparer();
	
			// Methods
			public bool Equals(Vector2 self, Vector2 vector);
			public int GetHashCode(Vector2 obj);
		}
	
		private sealed class Vector3EqualityComparer : IEqualityComparer<Vector3>
		{
			// Constructors
			public Vector3EqualityComparer();
	
			// Methods
			public bool Equals(Vector3 self, Vector3 vector);
			public int GetHashCode(Vector3 obj);
		}
	
		private sealed class Vector4EqualityComparer : IEqualityComparer<Vector4>
		{
			// Constructors
			public Vector4EqualityComparer();
	
			// Methods
			public bool Equals(Vector4 self, Vector4 vector);
			public int GetHashCode(Vector4 obj);
		}
	
		private sealed class ColorEqualityComparer : IEqualityComparer<Color>
		{
			// Constructors
			public ColorEqualityComparer();
	
			// Methods
			public bool Equals(Color self, Color other);
			public int GetHashCode(Color obj);
		}
	
		private sealed class RectEqualityComparer : IEqualityComparer<Rect>
		{
			// Constructors
			public RectEqualityComparer();
	
			// Methods
			public bool Equals(Rect self, Rect other);
			public int GetHashCode(Rect obj);
		}
	
		private sealed class BoundsEqualityComparer : IEqualityComparer<Bounds>
		{
			// Constructors
			public BoundsEqualityComparer();
	
			// Methods
			public bool Equals(Bounds self, Bounds vector);
			public int GetHashCode(Bounds obj);
		}
	
		private sealed class QuaternionEqualityComparer : IEqualityComparer<Quaternion>
		{
			// Constructors
			public QuaternionEqualityComparer();
	
			// Methods
			public bool Equals(Quaternion self, Quaternion vector);
			public int GetHashCode(Quaternion obj);
		}
	
		private sealed class Color32EqualityComparer : IEqualityComparer<Color32>
		{
			// Constructors
			public Color32EqualityComparer();
	
			// Methods
			public bool Equals(Color32 self, Color32 vector);
			public int GetHashCode(Color32 obj);
		}
	
		private sealed class Vector2IntEqualityComparer : IEqualityComparer<Vector2Int>
		{
			// Constructors
			public Vector2IntEqualityComparer();
	
			// Methods
			public bool Equals(Vector2Int self, Vector2Int vector);
			public int GetHashCode(Vector2Int obj);
		}
	
		private sealed class Vector3IntEqualityComparer : IEqualityComparer<Vector3Int>
		{
			// Fields
			public static readonly Vector3IntEqualityComparer Default;
	
			// Constructors
			public Vector3IntEqualityComparer();
			static Vector3IntEqualityComparer();
	
			// Methods
			public bool Equals(Vector3Int self, Vector3Int vector);
			public int GetHashCode(Vector3Int obj);
		}
	
		private sealed class RangeIntEqualityComparer : IEqualityComparer<RangeInt>
		{
			// Constructors
			public RangeIntEqualityComparer();
	
			// Methods
			public bool Equals(RangeInt self, RangeInt vector);
			public int GetHashCode(RangeInt obj);
		}
	
		private sealed class RectIntEqualityComparer : IEqualityComparer<RectInt>
		{
			// Constructors
			public RectIntEqualityComparer();
	
			// Methods
			public bool Equals(RectInt self, RectInt other);
			public int GetHashCode(RectInt obj);
		}
	
		private sealed class BoundsIntEqualityComparer : IEqualityComparer<BoundsInt>
		{
			// Constructors
			public BoundsIntEqualityComparer();
	
			// Methods
			public bool Equals(BoundsInt self, BoundsInt vector);
			public int GetHashCode(BoundsInt obj);
		}
	
		// Constructors
		static UnityEqualityComparer();
	
		// Methods
		public static IEqualityComparer<T> GetDefault<T>();
		private static object GetDefaultHelper(Type type);
	}
}
