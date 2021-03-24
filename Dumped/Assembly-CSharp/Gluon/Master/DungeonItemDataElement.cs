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
	public class DungeonItemDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private DungeonItemEffect _Effect;
		[SerializeField]
		private int _EffectValue;
	
		// Properties
		public int Id { get; }
		public DungeonItemEffect Effect { get; }
		public int EffectValue { get; }
	
		// Constructors
		public DungeonItemDataElement();
	}
}
