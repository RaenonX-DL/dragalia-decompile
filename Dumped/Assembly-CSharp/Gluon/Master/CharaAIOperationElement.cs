/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CharaAIOperationElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _ActiveRange;
		[SerializeField]
		private float _HealSkillHpRatio;
		[SerializeField]
		private float _SkillProbability;
		[SerializeField]
		private float _ProbabilityInterval;
	
		// Properties
		public int Id { get; }
		public float ActiveRange { get; }
		public float HealSkillHpRatio { get; }
		public float SkillProbability { get; }
		public float ProbabilityInterval { get; }
	
		// Constructors
		public CharaAIOperationElement();
	}
}
