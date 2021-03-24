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
	public class BuffFieldAttachmentData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _isAttachToBuffField;
		[HideInInspector]
		[SerializeField]
		private bool _isAttachToSelfBuffField;
		[HideInInspector]
		[SerializeField]
		private bool _enableApplyMultipleDebuff;
		[HideInInspector]
		[SerializeField]
		private EffectData _fieldEffect;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private float _hitDelaySec;
		[HideInInspector]
		[SerializeField]
		private bool _useSameComponent;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalHit;
		[HideInInspector]
		[SerializeField]
		private string _seName;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalHitLabel;
	
		// Properties
		public bool isAttachToBuffField { get; }
		public bool isAttachToSelfBuffField { get; }
		public bool enableApplyMultipleDebuff { get; }
		public EffectData fieldEffect { get; }
		public string hitAttrLabel { get; }
		public float hitDelaySec { get; }
		public bool useSameComponent { get; }
		public bool useElementalHit { get; }
		public string seName { get; }
		public string[] elementalHitLabel { get; }
	
		// Constructors
		public BuffFieldAttachmentData();
	}
}
