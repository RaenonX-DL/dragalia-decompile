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
	public class CharaAIParamElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ComboMaxProb;
		[SerializeField]
		private float _GridSize;
	
		// Properties
		public int Id { get; }
		public int ComboMaxProb { get; }
		public float GridSize { get; }
	
		// Constructors
		public CharaAIParamElement();
	}
}
