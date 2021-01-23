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
	public class MenuTalkElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _CharaId;
		[SerializeField]
		private int _MenuTalkGroupId;
		[SerializeField]
		private int _Category0;
		[SerializeField]
		private int _Category1;
		[SerializeField]
		private int _ImageTypeNum;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private string _VoiceData;
	
		// Properties
		public int CharaId { get; }
		public int MenuTalkGroupId { get; }
		public int Category0 { get; }
		public int Category1 { get; }
		public int ImageTypeNum { get; }
		public string Text { get; }
		public string VoiceData { get; }
	
		// Constructors
		public MenuTalkElement();
	}
}
