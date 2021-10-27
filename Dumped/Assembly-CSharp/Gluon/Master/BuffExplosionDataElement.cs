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
	public class BuffExplosionDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _HitAttrLabel;
		[SerializeField]
		private float _HitRange;
		[SerializeField]
		private string _EffectName;
		[SerializeField]
		private int _EffectTrigger;
		[SerializeField]
		private string _SeName;
	
		// Properties
		public int Id { get; }
		public string HitAttrLabel { get; }
		public float HitRange { get; }
		public string EffectName { get; }
		public int EffectTrigger { get; }
		public string SeName { get; }
	
		// Constructors
		public BuffExplosionDataElement();
	}
}
