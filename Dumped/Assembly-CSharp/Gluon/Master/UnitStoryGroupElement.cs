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
	public class UnitStoryGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _Type;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _HiraganaPrinted;
		[SerializeField]
		private int _BaseId;
		[SerializeField]
		private int _VariationId;
	
		// Properties
		public int Id { get; }
		public int Type { get; }
		public string Name { get; }
		public string HiraganaPrinted { get; }
		public int BaseId { get; }
		public int VariationId { get; }
	
		// Constructors
		public UnitStoryGroupElement();
	}
}
