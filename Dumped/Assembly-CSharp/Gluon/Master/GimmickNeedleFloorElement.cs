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
	public class GimmickNeedleFloorElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private float _IntervalSec;
		[SerializeField]
		private string _ActionHitAttribute;
		[SerializeField]
		private float _Attack;
		[SerializeField]
		private int _RateDamage;
	
		// Properties
		public string Id { get; }
		public float IntervalSec { get; }
		public string ActionHitAttribute { get; }
		public float Attack { get; }
		public int RateDamage { get; }
	
		// Constructors
		public GimmickNeedleFloorElement();
	}
}
