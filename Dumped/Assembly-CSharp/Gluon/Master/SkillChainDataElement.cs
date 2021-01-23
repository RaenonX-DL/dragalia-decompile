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
	public class SkillChainDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private int _ActivateCondition;
		[SerializeField]
		private int _ConditionArgs1;
	
		// Properties
		public int Id { get; }
		public int GroupId { get; }
		public int ActivateCondition { get; }
		public int ConditionArgs1 { get; }
	
		// Constructors
		public SkillChainDataElement();
	}
}
