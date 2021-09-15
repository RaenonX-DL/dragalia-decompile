/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiMoveData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsMultiMove.TargetType _targetType;
		[HideInInspector]
		[SerializeField]
		private ActionPartsMultiMove.BaseType _baseType;
		[HideInInspector]
		[SerializeField]
		private int _fixedPosNum;
		[HideInInspector]
		[SerializeField]
		private Vector3[] _arrayFixedPos;
		[HideInInspector]
		[SerializeField]
		private float _moveSpeed;
		[HideInInspector]
		[SerializeField]
		private float _interval;
		[HideInInspector]
		[SerializeField]
		private float _turnTime;
		[HideInInspector]
		[SerializeField]
		private string _moveMotion;
		[HideInInspector]
		[SerializeField]
		private bool _isInvincible;
	
		// Properties
		public ActionPartsMultiMove.TargetType targetType { get; }
		public ActionPartsMultiMove.BaseType baseType { get; }
		public int fixedPosNum { get; }
		public Vector3[] arrayFixedPos { get; }
		public float moveSpeed { get; }
		public float interval { get; }
		public float turnTime { get; }
		public string moveMotion { get; }
		public bool isInvincible { get; }
	
		// Constructors
		public MultiMoveData();
	}
}
