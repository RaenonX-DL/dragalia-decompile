/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class ActionGrantElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _DurationSec;
		[SerializeField]
		private AbilityTargetAction _TargetAction;
		[SerializeField]
		private int _GrantCondition;
		[SerializeField]
		private int _Attribute;
	
		// Properties
		public int Id { get; }
		public float DurationSec { get; }
		public AbilityTargetAction TargetAction { get; }
		public int GrantCondition { get; }
		public int Attribute { get; }
	
		// Constructors
		public ActionGrantElement();
	}
}
