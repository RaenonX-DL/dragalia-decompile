﻿/*
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
	public class HypnosWindyStreamData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _hitAttributeLabel;
		[HideInInspector]
		[SerializeField]
		private float _waitTime;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
	
		// Properties
		public string hitAttributeLabel { get; }
		public float waitTime { get; }
		public int childActionId { get; }
	
		// Constructors
		public HypnosWindyStreamData();
	}
}
