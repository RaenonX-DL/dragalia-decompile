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
	public class DragonDecorationElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ModelId;
		[SerializeField]
		private string _SummonAnimationName;
		[SerializeField]
		private string _NodeName;
		[SerializeField]
		private bool _IsFirstVisible;
	
		// Properties
		public int Id { get; }
		public int ModelId { get; }
		public string SummonAnimationName { get; }
		public string NodeName { get; }
		public bool IsFirstVisible { get; }
	
		// Constructors
		public DragonDecorationElement();
	}
}
