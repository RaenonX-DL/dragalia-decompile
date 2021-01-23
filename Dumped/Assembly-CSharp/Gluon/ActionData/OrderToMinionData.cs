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
	public class OrderToMinionData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _minionId;
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
		private bool _afterExtraAction;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public int minionId { get; }
		public int orderActionId { get; }
		public bool isLinkTarget { get; }
		public bool cancelStopAbnormal { get; }
		public bool afterExtraAction { get; }
		public bool guarantee { get; }
	
		// Constructors
		public OrderToMinionData();
	}
}
