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
	public class SeitentaiseiHealData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _checkEnemyId;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _hitAttributeLabel;
		[HideInInspector]
		[SerializeField]
		private float _healIntervalSec;
	
		// Properties
		public int checkEnemyId { get; }
		public string effectName { get; }
		public string hitAttributeLabel { get; }
		public float healIntervalSec { get; }
	
		// Constructors
		public SeitentaiseiHealData();
	}
}
