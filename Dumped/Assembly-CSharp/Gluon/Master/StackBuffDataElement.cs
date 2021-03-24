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
	public class StackBuffDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _LimitNum;
		[SerializeField]
		private BuffType _BuffType1;
		[SerializeField]
		private float _Rate1;
		[SerializeField]
		private BuffType _BuffType2;
		[SerializeField]
		private float _Rate2;
		[SerializeField]
		private BuffType _BuffType3;
		[SerializeField]
		private float _Rate3;
	
		// Properties
		public int Id { get; }
		public int LimitNum { get; }
		public BuffType BuffType1 { get; }
		public float Rate1 { get; }
		public BuffType BuffType2 { get; }
		public float Rate2 { get; }
		public BuffType BuffType3 { get; }
		public float Rate3 { get; }
	
		// Constructors
		public StackBuffDataElement();
	}
}
