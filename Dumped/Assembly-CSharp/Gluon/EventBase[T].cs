/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[MessagePackObject]
	public class EventBase<T>
		where T : EventBase<T>
	{
		// Fields
		[CompilerGenerated]
		private int _actorId_k__BackingField;
		[Key]
		public ushort _raiseEventSequenceId;
	
		// Properties
		[IgnoreMember]
		public int actorId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public EventBase();
	
		// Methods
		public byte[] Serialize(ushort nextSequenceId);
		public static T Deserialize(EventData photonEvent);
	}
}
