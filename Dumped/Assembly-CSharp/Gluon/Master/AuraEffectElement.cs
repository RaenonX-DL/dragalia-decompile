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
	public class AuraEffectElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _EffectName;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private int _TriggerType;
		[SerializeField]
		private string _BindPos;
	
		// Properties
		public int Id { get; }
		public string EffectName { get; }
		public int GroupId { get; }
		public int TriggerType { get; }
		public string BindPos { get; }
	
		// Constructors
		public AuraEffectElement();
	}
}
