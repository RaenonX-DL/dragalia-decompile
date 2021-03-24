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
	public class BuffCountDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _LimitRate;
		[SerializeField]
		private float _BaseRate;
		[SerializeField]
		private int _Condition1Id;
		[SerializeField]
		private float _Condition1Rate;
	
		// Properties
		public int Id { get; }
		public float LimitRate { get; }
		public float BaseRate { get; }
		public int Condition1Id { get; }
		public float Condition1Rate { get; }
	
		// Constructors
		public BuffCountDataElement();
	}
}
