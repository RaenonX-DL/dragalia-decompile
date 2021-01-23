/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class GuildSystemMessageElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _GuildTextType;
		[SerializeField]
		private string _Message;
		[SerializeField]
		private MessageReplaceTextType _Type1;
		[SerializeField]
		private MessageReplaceTextType _Type2;
		[SerializeField]
		private MessageReplaceTextType _Type3;
		[SerializeField]
		private MessageReplaceTextType _Type4;
	
		// Properties
		public int Id { get; }
		public int GuildTextType { get; }
		public string Message { get; }
		public MessageReplaceTextType Type1 { get; }
		public MessageReplaceTextType Type2 { get; }
		public MessageReplaceTextType Type3 { get; }
		public MessageReplaceTextType Type4 { get; }
	
		// Constructors
		public GuildSystemMessageElement();
	}
}
