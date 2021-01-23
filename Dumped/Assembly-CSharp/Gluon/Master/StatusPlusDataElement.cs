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
	public class StatusPlusDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _Hp;
		[SerializeField]
		private int _Attack;
		[SerializeField]
		private int _Defense;
	
		// Properties
		public int Id { get; }
		public int Hp { get; }
		public int Attack { get; }
		public int Defense { get; }
	
		// Constructors
		public StatusPlusDataElement();
	}
}
