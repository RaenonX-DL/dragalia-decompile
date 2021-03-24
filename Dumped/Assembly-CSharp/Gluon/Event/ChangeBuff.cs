/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class ChangeBuff : EventBase<ChangeBuff>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId character;
		[Key]
		[Required]
		public List<ParameterSyncData> addParameters;
		[Key]
		[Required]
		public List<RemoveSyncData> removeParameters;
		[Key]
		[Required]
		public List<RegenerationSyncData> addRegenerations;
		[Key]
		[Required]
		public List<RemoveSyncData> removeRegenerations;
		[Key]
		[Required]
		public List<GrantSyncData> addGrants;
		[Key]
		[Required]
		public List<RemoveSyncData> removeGrants;
		[Key]
		[Required]
		public List<UnifiedParameterSyncData> addUnifiedParameters;
		[Key]
		[Required]
		public List<RemoveSyncData> removeUnifiedParameters;
	
		// Constructors
		public ChangeBuff();
	}
}
