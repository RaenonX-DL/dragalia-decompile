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
	public class AbilityLimitedGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _IsEffectMix;
		[SerializeField]
		private float _MaxLimitedValue;
		[SerializeField]
		private string _AbilityLimitedText;
	
		// Properties
		public int Id { get; }
		public int IsEffectMix { get; }
		public float MaxLimitedValue { get; }
		public string AbilityLimitedText { get; }
	
		// Constructors
		public AbilityLimitedGroupElement();
	}
}
