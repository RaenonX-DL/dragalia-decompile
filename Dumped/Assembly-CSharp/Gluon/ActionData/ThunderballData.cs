/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ThunderballData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private float _lifetime;
		[HideInInspector]
		[SerializeField]
		private int _sparktimes;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private Vector3 _lineSize;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _seSpawn;
		[HideInInspector]
		[SerializeField]
		private string _seDischarge;
		public const float DEFAULT_HIT_INTERVAL = 0.5f;
		[HideInInspector]
		[SerializeField]
		private float _collisionHitInterval;
	
		// Properties
		public InGameDef.CharacterType characterType { get; }
		public string hitAttrLabel { get; }
		public float lifetime { get; }
		public int sparktimes { get; }
		public float radius { get; }
		public Vector3 lineSize { get; }
		public string effectName { get; }
		public string seSpawn { get; }
		public string seDischarge { get; }
		public float collisionHitInterval { get; }
	
		// Constructors
		public ThunderballData();
	}
}
