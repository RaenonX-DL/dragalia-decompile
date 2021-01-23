/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class IceRayData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetRotation;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offset;
		[HideInInspector]
		[SerializeField]
		private float _rayLength;
		[HideInInspector]
		[SerializeField]
		private int _subActionID;
		[HideInInspector]
		[SerializeField]
		private string _subEnemyGroupName;
		[HideInInspector]
		[SerializeField]
		private bool _isRotationYaw;
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private GeneratePos _generatePos;
	
		// Properties
		public Vector3 offsetRotation { get; }
		public Vector3 offset { get; }
		public float rayLength { get; }
		public int subActionID { get; }
		public string subEnemyGroupName { get; }
		public bool isRotationYaw { get; }
		public string attachNodeName { get; }
		public GeneratePos generatePos { get; }
	
		// Nested types
		public enum GeneratePos
		{
			Owner = 0,
			OwnerNode = 1
		}
	
		// Constructors
		public IceRayData();
	}
}
