/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class ActionMarkerElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _HitAttribute;
		[SerializeField]
		private float _PrepareSec;
		[SerializeField]
		private ActionMarkerShape _ShapeType;
		[SerializeField]
		private float _NearRange;
		[SerializeField]
		private float _FarRange;
		[SerializeField]
		private int _Attach;
		[SerializeField]
		private int _IsSelf;
		[SerializeField]
		private int _IsImpactWait;
		[SerializeField]
		private int _IsAICognition;
	
		// Properties
		public int Id { get; }
		public string HitAttribute { get; }
		public float PrepareSec { get; }
		public ActionMarkerShape ShapeType { get; }
		public float NearRange { get; }
		public float FarRange { get; }
		public int Attach { get; }
		public int IsSelf { get; }
		public int IsImpactWait { get; }
		public int IsAICognition { get; }
	
		// Constructors
		public ActionMarkerElement();
	}
}
