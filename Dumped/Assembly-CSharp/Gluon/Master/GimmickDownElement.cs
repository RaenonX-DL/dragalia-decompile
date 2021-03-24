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
	public class GimmickDownElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private float _SensingRangeX;
		[SerializeField]
		private float _SensingRangeZ;
		[SerializeField]
		private string _ActionHitAttribute;
		[SerializeField]
		private ActionMarker _Marker;
		[SerializeField]
		private float _Attack;
		[SerializeField]
		private int _RateDamage;
	
		// Properties
		public string Id { get; }
		public float SensingRangeX { get; }
		public float SensingRangeZ { get; }
		public string ActionHitAttribute { get; }
		public ActionMarker Marker { get; }
		public float Attack { get; }
		public int RateDamage { get; }
	
		// Constructors
		public GimmickDownElement();
	}
}
