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
	public class GimmickThunderboltElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private float _SensingRange;
		[SerializeField]
		private float _Range;
		[SerializeField]
		private float _IntervalSec;
		[SerializeField]
		private float _ReviveSec;
		[SerializeField]
		private int _TriggeringNumber;
		[SerializeField]
		private ActionMarker _Marker;
		[SerializeField]
		private string _HitAttribute;
		[SerializeField]
		private float _Attack;
		[SerializeField]
		private int _RateDamage;
	
		// Properties
		public string Id { get; }
		public float SensingRange { get; }
		public float Range { get; }
		public float IntervalSec { get; }
		public float ReviveSec { get; }
		public int TriggeringNumber { get; }
		public ActionMarker Marker { get; }
		public string HitAttribute { get; }
		public float Attack { get; }
		public int RateDamage { get; }
	
		// Constructors
		public GimmickThunderboltElement();
	}
}
