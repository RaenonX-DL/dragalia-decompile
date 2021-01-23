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
	public class FieldTalkElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _BaseId;
		[SerializeField]
		private int _VariationId;
		[SerializeField]
		private int _TypeId;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private int _WindowType;
		[SerializeField]
		private string _VoiceId;
	
		// Properties
		public int Id { get; }
		public int BaseId { get; }
		public int VariationId { get; }
		public int TypeId { get; }
		public string Text { get; }
		public int WindowType { get; }
		public string VoiceId { get; }
	
		// Constructors
		public FieldTalkElement();
	}
}
