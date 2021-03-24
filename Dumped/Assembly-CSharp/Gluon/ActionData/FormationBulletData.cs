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
	public class FormationBulletData : BulletData
	{
		// Fields
		public static readonly int childNumMax;
		[HideInInspector]
		[SerializeField]
		private int _childNum;
		[HideInInspector]
		[SerializeField]
		private ChildParameter[] _child;
		[HideInInspector]
		[SerializeField]
		private Vector3 _rotationSpeed;
		[HideInInspector]
		[SerializeField]
		private FireTrigger _fireTrigger;
		[HideInInspector]
		[SerializeField]
		private bool _noCheckCollision;
		[HideInInspector]
		[SerializeField]
		private bool _destroyAlone;
		[HideInInspector]
		[SerializeField]
		private bool _overrideExistingFormationBullet;
		[HideInInspector]
		[SerializeField]
		private SoundEffect _se;
	
		// Properties
		public int childNum { get; }
		public ChildParameter[] child { get; }
		public Vector3 rotationSpeed { get; }
		public FireTrigger fireTrigger { get; }
		public bool noCheckCollision { get; }
		public bool destroyAlone { get; }
		public bool overrideExistingFormationBullet { get; }
		public SoundEffect se { get; }
	
		// Nested types
		[Serializable]
		public class ChildParameter
		{
			// Fields
			public bool isFoldout;
			public Vector3 offsetPos;
			public BulletData bulletData;
	
			// Constructors
			public ChildParameter();
		}
	
		[Flags]
		public enum FireTrigger
		{
			None = 0,
			Generate = 1,
			CharacterMove = 2,
			FixedTime = 4,
			Tap = 8
		}
	
		[Serializable]
		public class SoundEffect
		{
			// Fields
			public string name;
			public string controllerKey;
			public float fadeoutTime;
	
			// Constructors
			public SoundEffect();
		}
	
		// Constructors
		public FormationBulletData();
		static FormationBulletData();
	}
}
