/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CheatDetectionParamElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _MaxEnemyDamage;
		[SerializeField]
		private int _MaxEnemyBreakDamage;
		[SerializeField]
		private int _MaxEnemyPlayerDistance;
		[SerializeField]
		private int _MaxPlayerHeal;
		[SerializeField]
		private float _MaxPlayerMoveSpeed;
	
		// Properties
		public int Id { get; }
		public int MaxEnemyDamage { get; }
		public int MaxEnemyBreakDamage { get; }
		public int MaxEnemyPlayerDistance { get; }
		public int MaxPlayerHeal { get; }
		public float MaxPlayerMoveSpeed { get; }
	
		// Constructors
		public CheatDetectionParamElement();
	}
}
