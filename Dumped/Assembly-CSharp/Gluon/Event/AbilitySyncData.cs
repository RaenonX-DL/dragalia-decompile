/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class AbilitySyncData
	{
		// Fields
		[Key]
		public ushort requireCnt;
		[Key]
		public ushort activateNum;
		[Key]
		public ushort expireCnt;
		[Key]
		public bool isChanged;
	
		// Constructors
		public AbilitySyncData();
	}
}
