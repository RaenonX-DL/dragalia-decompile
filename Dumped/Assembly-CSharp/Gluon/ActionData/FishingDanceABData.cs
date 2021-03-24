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
	public class FishingDanceABData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _isDanceA;
		[HideInInspector]
		[SerializeField]
		private float _expanSec;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
		[HideInInspector]
		[SerializeField]
		private float _childSpace;
		[HideInInspector]
		[SerializeField]
		private float _childDistance;
	
		// Properties
		public bool isDanceA { get; }
		public float expanSec { get; }
		public int childActionId { get; }
		public float childSpace { get; }
		public float childDistance { get; }
	
		// Constructors
		public FishingDanceABData();
	}
}
