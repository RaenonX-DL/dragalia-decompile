/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class OrderToSubData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private SubCharaType _subType;
		[HideInInspector]
		[SerializeField]
		private int _subIdx;
		[HideInInspector]
		[SerializeField]
		private bool _isOrderAllSub;
		[HideInInspector]
		[SerializeField]
		private int _orderActionId;
		[HideInInspector]
		[SerializeField]
		private bool _isLinkTarget;
		[HideInInspector]
		[SerializeField]
		private bool _cancelStopAbnormal;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public SubCharaType subType { get; }
		public int subIdx { get; }
		public bool isOrderAllSub { get; }
		public int orderActionId { get; }
		public bool isLinkTarget { get; }
		public bool cancelStopAbnormal { get; }
		public bool guarantee { get; }
	
		// Nested types
		public enum SubCharaType
		{
			SubCharaType01Param = 0,
			SubCharaType02Param = 1,
			SubCharaType03Param = 2
		}
	
		// Constructors
		public OrderToSubData();
	}
}
