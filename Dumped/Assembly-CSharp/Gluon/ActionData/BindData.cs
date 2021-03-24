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
	public class BindData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsBind.BindType _bindType;
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private Vector3 _targetOffsetPos;
		[HideInInspector]
		[SerializeField]
		private bool _isDamagePose;
		[HideInInspector]
		[SerializeField]
		private bool _isCancelDragon;
		[HideInInspector]
		[SerializeField]
		private bool _isHideTaget;
		[HideInInspector]
		[SerializeField]
		private bool _isInvincibleTaget;
		[HideInInspector]
		[SerializeField]
		private int _invincibleLevel;
		[HideInInspector]
		[SerializeField]
		private bool _cannotBindNpcAvoid;
		[HideInInspector]
		[SerializeField]
		private bool _isMoveSyncDisabled;
	
		// Properties
		public ActionPartsBind.BindType bindType { get; }
		public string attachNodeName { get; }
		public Vector3 targetOffsetPos { get; }
		public bool isDamagePose { get; }
		public bool isCancelDragon { get; }
		public bool isHideTaget { get; }
		public bool isInvincibleTaget { get; }
		public int invincibleLevel { get; }
		public bool cannotBindNpcAvoid { get; }
		public bool isMoveSyncDisabled { get; }
	
		// Constructors
		public BindData();
	}
}
