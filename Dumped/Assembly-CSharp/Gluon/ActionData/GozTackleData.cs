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
	public class GozTackleData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _tackleDistance;
		[HideInInspector]
		[SerializeField]
		private float _tackleSpeed;
		[HideInInspector]
		[SerializeField]
		private float _tackleInterval;
		[HideInInspector]
		[SerializeField]
		private float _returnInterval;
		[HideInInspector]
		[SerializeField]
		private string _tackleMotion;
		[HideInInspector]
		[SerializeField]
		private string _returnMotion;
		[HideInInspector]
		[SerializeField]
		private MarkerData _marker;
		[HideInInspector]
		[SerializeField]
		private string _hitDifficultyLabel;
		[HideInInspector]
		[SerializeField]
		private float _collisionRadius;
		public const float DEFAULT_HIT_INTERVAL = 0.5f;
		[HideInInspector]
		[SerializeField]
		private float _collisionHitInterval;
		[HideInInspector]
		[SerializeField]
		private int _crashActionId;
		[HideInInspector]
		[SerializeField]
		private string _auraEffKey;
		[HideInInspector]
		[SerializeField]
		private string _returnEffect;
		[HideInInspector]
		[SerializeField]
		private string _seCharge;
		[HideInInspector]
		[SerializeField]
		private string _seTackle;
		[HideInInspector]
		[SerializeField]
		private string _seReturn;
	
		// Properties
		public float tackleDistance { get; }
		public float tackleSpeed { get; }
		public float tackleInterval { get; }
		public float returnInterval { get; }
		public string tackleMotion { get; }
		public string returnMotion { get; }
		public MarkerData marker { get; }
		public string hitDifficultyLabel { get; }
		public float collisionRadius { get; }
		public float collisionHitInterval { get; }
		public int crashActionId { get; }
		public string auraEffKey { get; }
		public string returnEffect { get; }
		public string seCharge { get; }
		public string seTackle { get; }
		public string seReturn { get; }
	
		// Constructors
		public GozTackleData();
	}
}
