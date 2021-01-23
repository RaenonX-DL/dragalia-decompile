/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.EnemyDef
{
	[Serializable]
	public class AttackData
	{
		// Fields
		[SerializeField]
		public InGameDef.AttackRange attackRange;
		[SerializeField]
		public string motionName;
		[SerializeField]
		public float beforeInterval;
		[SerializeField]
		public float afterInterval;
		[SerializeField]
		public float activeRange;
		[SerializeField]
		protected float[] _hitFrames;
		[SerializeField]
		public float sleepInterval;
	
		// Constructors
		public AttackData();
	
		// Methods
		public static AttackData Default();
		public static void SetupDefault(ref AttackData data);
		public void CopyTo(AttackData target);
	}
}
