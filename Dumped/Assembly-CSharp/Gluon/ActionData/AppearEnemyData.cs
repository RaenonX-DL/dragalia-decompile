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
	public class AppearEnemyData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ChildType _childType;
		[HideInInspector]
		[SerializeField]
		private PopType _popType;
		[HideInInspector]
		[SerializeField]
		private PopDesign _popDesign;
		[HideInInspector]
		[SerializeField]
		private float _popAngle;
		[HideInInspector]
		[SerializeField]
		private float _popLength;
		[HideInInspector]
		[SerializeField]
		private Vector3 _popOffsetPos;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
		[HideInInspector]
		[SerializeField]
		private bool _isDirectionEdit;
		[HideInInspector]
		[SerializeField]
		private float _childDirection;
		[HideInInspector]
		[SerializeField]
		private bool _production;
		[HideInInspector]
		[SerializeField]
		private bool _devolution;
		[HideInInspector]
		[SerializeField]
		private bool _isPopedInvincible;
		[HideInInspector]
		[SerializeField]
		private bool _isHostSync;
		[HideInInspector]
		[SerializeField]
		private bool _checkFloor;
	
		// Properties
		public ChildType childType { get; }
		public PopType popType { get; }
		public PopDesign popDesign { get; }
		public float popAngle { get; }
		public float popLength { get; }
		public Vector3 popOffsetPos { get; }
		public int childActionId { get; }
		public bool isDirectionEdit { get; }
		public float childDirection { get; }
		public bool production { get; }
		public bool devolution { get; }
		public bool isPopedInvincible { get; }
		public bool IsHostSync { get; }
		public bool checkFloor { get; }
	
		// Nested types
		public enum ChildType
		{
			Child01Param = 0,
			Child02Param = 1,
			Child03Param = 2
		}
	
		public enum PopType
		{
			Owner = 0,
			WorldCenter = 1,
			Target = 2,
			AreaAnchor = 3,
			TargetGround = 4
		}
	
		public enum PopDesign
		{
			Direction = 0,
			Offset = 1
		}
	
		// Constructors
		public AppearEnemyData();
	}
}
