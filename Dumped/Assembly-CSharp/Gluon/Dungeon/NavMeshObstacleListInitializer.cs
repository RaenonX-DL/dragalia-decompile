/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class NavMeshObstacleListInitializer : MonoBehaviour
	{
		// Nested types
		[Serializable]
		public class ObstacleData
		{
			// Fields
			public Vector3 boxOffset;
			[Range]
			public float rotY;
			public Vector3 boxSize;
	
			// Constructors
			public ObstacleData(Vector3 offset, Vector3 size);
		}
	
		// Constructors
		public NavMeshObstacleListInitializer();
	
		// Methods
		private void Awake();
	}
}
