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
	public class DefenseEventSystemInfoElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _QuestGroupId;
		[SerializeField]
		private int _QuestId;
		[SerializeField]
		private string _FortDamageText;
		[SerializeField]
		private string _FortDyingText;
		[SerializeField]
		private string _FortDeadText;
		[SerializeField]
		private string _HouseDeadText;
		[SerializeField]
		private string _NextAreaText;
	
		// Properties
		public int Id { get; }
		public int QuestGroupId { get; }
		public int QuestId { get; }
		public string FortDamageText { get; }
		public string FortDyingText { get; }
		public string FortDeadText { get; }
		public string HouseDeadText { get; }
		public string NextAreaText { get; }
	
		// Constructors
		public DefenseEventSystemInfoElement();
	}
}
