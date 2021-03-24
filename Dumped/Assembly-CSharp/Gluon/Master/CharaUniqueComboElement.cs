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
	public class CharaUniqueComboElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ActionId;
		[SerializeField]
		private int _ExActionId;
		[SerializeField]
		private int _MaxComboNum;
		[SerializeField]
		private int _ShiftConditionType;
		[SerializeField]
		private int _ConditionArgs1;
		[SerializeField]
		private string _BuffHitAttribute;
	
		// Properties
		public int Id { get; }
		public int ActionId { get; }
		public int ExActionId { get; }
		public int MaxComboNum { get; }
		public int ShiftConditionType { get; }
		public int ConditionArgs1 { get; }
		public string BuffHitAttribute { get; }
	
		// Constructors
		public CharaUniqueComboElement();
	}
}
