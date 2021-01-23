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
	public class HumanCannonData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private float _waitPick;
		[HideInInspector]
		[SerializeField]
		private float _reelTime;
		[HideInInspector]
		[SerializeField]
		private float _waitFire;
		[HideInInspector]
		[SerializeField]
		private float _velocity;
		[HideInInspector]
		[SerializeField]
		private Vector3 _fireOffset;
		[HideInInspector]
		[SerializeField]
		private string _crashHitDifficultyLabel;
		[HideInInspector]
		[SerializeField]
		private string _freedHitDifficultyLabel;
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private float _attachTiming;
		[HideInInspector]
		[SerializeField]
		private string _lightballEffName;
		[HideInInspector]
		[SerializeField]
		private int _startTrigger;
		[HideInInspector]
		[SerializeField]
		private int _freedTrigger;
		[HideInInspector]
		[SerializeField]
		private string _startSeName;
		[HideInInspector]
		[SerializeField]
		private string _fireSeName;
		[HideInInspector]
		[SerializeField]
		private string _freedSeName;
	
		// Properties
		public float radius { get; }
		public float waitPick { get; }
		public float reelTime { get; }
		public float waitFire { get; }
		public float velocity { get; }
		public Vector3 fireOffset { get; }
		public string crashHitDifficultyLabel { get; }
		public string freedHitDifficultyLabel { get; }
		public string attachNodeName { get; }
		public float attachTiming { get; }
		public string lightballEffName { get; }
		public int startTrigger { get; }
		public int freedTrigger { get; }
		public string startSeName { get; }
		public string fireSeName { get; }
		public string freedSeName { get; }
	
		// Constructors
		public HumanCannonData();
	}
}
