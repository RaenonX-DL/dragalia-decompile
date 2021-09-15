/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class DispBuffCaptionEvent : EventBase<DispBuffCaptionEvent>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId sender;
		[Key]
		public int type;
		[Key]
		public string iconName;
		[Key]
		public float rate;
		[Key]
		public string text;
		[Key]
		public int iconType;
		[Key]
		public bool isDisplayCheck;
		[Key]
		public int conditionId;
	
		// Constructors
		public DispBuffCaptionEvent();
	}
}
