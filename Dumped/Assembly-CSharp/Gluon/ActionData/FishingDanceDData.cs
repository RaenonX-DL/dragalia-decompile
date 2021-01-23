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
	public class FishingDanceDData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _expanLengthInward;
		[HideInInspector]
		[SerializeField]
		private float _expanLengthOutside;
		[HideInInspector]
		[SerializeField]
		private float _expanSec;
		[HideInInspector]
		[SerializeField]
		private float _rollingCntInward;
		[HideInInspector]
		[SerializeField]
		private float _rollingCntOutside;
		[HideInInspector]
		[SerializeField]
		private float _rollingSec;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
	
		// Properties
		public float expanLengthInward { get; }
		public float expanLengthOutside { get; }
		public float expanSec { get; }
		public float rollingCntInward { get; }
		public float rollingCntOutside { get; }
		public float rollingSec { get; }
		public int childActionId { get; }
	
		// Constructors
		public FishingDanceDData();
	}
}
