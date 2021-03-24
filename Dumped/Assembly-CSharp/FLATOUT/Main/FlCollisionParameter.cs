/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlCollisionParameter
	{
		// Fields
		public FlCollisionTypes _collisionType;
		public Vector3 _offset;
		public float _scale;
		public bool _through;
	
		// Properties
		public FlCollisionTypes CollisionType { get; set; }
		public float Scale { get; set; }
		public Vector3 Offset { get; set; }
		public bool Through { get; set; }
	
		// Constructors
		public FlCollisionParameter();
	
		// Methods
		public void _CreateHierarchy(FlRoot root, GameObject parentGameObject);
	}
}
