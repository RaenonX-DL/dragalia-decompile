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
	public class AuraEffectGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _Priority;
		[SerializeField]
		private int _CoexistGroupId1;
		[SerializeField]
		private int _CoexistGroupId2;
		[SerializeField]
		private int _CoexistGroupId3;
	
		// Properties
		public int Id { get; }
		public int Priority { get; }
		public int CoexistGroupId1 { get; }
		public int CoexistGroupId2 { get; }
		public int CoexistGroupId3 { get; }
	
		// Constructors
		public AuraEffectGroupElement();
	}
}
