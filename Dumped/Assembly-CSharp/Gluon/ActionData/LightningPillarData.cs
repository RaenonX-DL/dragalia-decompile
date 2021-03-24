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
	public class LightningPillarData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _chargeTime;
		[HideInInspector]
		[SerializeField]
		private string _hitAttributeLabel;
		[HideInInspector]
		[SerializeField]
		private float _waitTime;
		[HideInInspector]
		[SerializeField]
		private float _cyclicInterval;
		[HideInInspector]
		[SerializeField]
		private string _cyclicHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private float _cyclicHitRadius;
		[HideInInspector]
		[SerializeField]
		private string _cyclicEffectLabel;
		[HideInInspector]
		[SerializeField]
		private float _signTime;
		[HideInInspector]
		[SerializeField]
		private string _signEffectLabel;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
	
		// Properties
		public float chargeTime { get; }
		public string hitAttributeLabel { get; }
		public float waitTime { get; }
		public float cyclicInterval { get; }
		public string cyclicHitAttrLabel { get; }
		public float cyclicHitRadius { get; }
		public string cyclicEffectLabel { get; }
		public float signTime { get; }
		public string signEffectLabel { get; }
		public int childActionId { get; }
	
		// Constructors
		public LightningPillarData();
	}
}
