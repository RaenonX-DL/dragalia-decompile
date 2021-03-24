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
	public class DamageDampingElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _DampingCoef;
		[SerializeField]
		private int _Combo;
		[SerializeField]
		private int _HumanSkill;
		[SerializeField]
		private int _DragonSkillLevel1;
		[SerializeField]
		private int _DragonSkillLevel2;
	
		// Properties
		public int Id { get; }
		public float DampingCoef { get; }
		public int Combo { get; }
		public int HumanSkill { get; }
		public int DragonSkillLevel1 { get; }
		public int DragonSkillLevel2 { get; }
	
		// Constructors
		public DamageDampingElement();
	}
}
