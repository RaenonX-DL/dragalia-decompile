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
	public class B00254Data : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Behavior _behavior;
		[HideInInspector]
		[SerializeField]
		private int _generateNum;
		[HideInInspector]
		[SerializeField]
		private float _generateDelay;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMin;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMax;
		[HideInInspector]
		[SerializeField]
		private bool _isGenerateRangeRandom;
		[HideInInspector]
		[SerializeField]
		private MarkerData _marker;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalHit;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalHitLabel;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalEffectName;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _effectInfluencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _effectUseElementalTrigger;
	
		// Properties
		public Behavior behavior { get; }
		public int generateNum { get; }
		public float generateDelay { get; }
		public float generateRangeMin { get; }
		public float generateRangeMax { get; }
		public bool isGenerateRangeRandom { get; }
		public MarkerData markerData { get; }
		public string hitAttrLabel { get; }
		public bool useElementalHit { get; }
		public string[] elementalHitLabel { get; }
		public string effectName { get; }
		public string[] elementalEffectName { get; }
		public int effectTriggerIdx { get; }
		public bool effectInfluencedCharaterElement { get; }
		public bool effectUseElementalTrigger { get; }
	
		// Nested types
		public enum Behavior
		{
			attack = 0,
			retreat = 1
		}
	
		// Constructors
		public B00254Data();
	}
}
