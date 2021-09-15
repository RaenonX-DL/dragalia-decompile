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
	public class OperateDrasticForceData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateDrasticForce.OperateType _operateType;
		[HideInInspector]
		[SerializeField]
		private int _value;
		[HideInInspector]
		[SerializeField]
		private bool _isResetTimer;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsOperateDrasticForce.OperateType operateType { get; }
		public int value { get; }
		public bool isResetTimer { get; }
		public bool guarantee { get; }
	
		// Constructors
		public OperateDrasticForceData();
	}
}
