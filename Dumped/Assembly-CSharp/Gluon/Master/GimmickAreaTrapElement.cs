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
	public class GimmickAreaTrapElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private string _CommonActionHitAttr;
		[SerializeField]
		private int _Attack;
		[SerializeField]
		private int _RateDamage;
		[SerializeField]
		private float _HitTime;
		[SerializeField]
		private float _CoolTime;
		[SerializeField]
		private float _MarkerSize;
		[SerializeField]
		private float _TrapHitSize;
	
		// Properties
		public string Id { get; }
		public string CommonActionHitAttr { get; }
		public int Attack { get; }
		public int RateDamage { get; }
		public float HitTime { get; }
		public float CoolTime { get; }
		public float MarkerSize { get; }
		public float TrapHitSize { get; }
	
		// Constructors
		public GimmickAreaTrapElement();
	}
}
