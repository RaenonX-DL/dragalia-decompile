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
	public class BindGimmickDungeonObject : DungeonObjectParameterBase
	{
		// Fields
		[Key]
		public BindGimmickEventType type;
		[Key]
		public long bindEventId;
		[Key]
		public BindEvent ctrlBindData;
	
		// Nested types
		public enum BindGimmickEventType : byte
		{
			StartAction = 0,
			Fire = 1,
			CtrlBind = 2
		}
	
		// Constructors
		public BindGimmickDungeonObject();
	}
}
