using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ChangeBuff : EventBase<ChangeBuff>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Required]
		[Key(2)]
		public List<ParameterSyncData> addParameters;

		[Required]
		[Key(3)]
		public List<RemoveSyncData> removeParameters;

		[Required]
		[Key(4)]
		public List<RegenerationSyncData> addRegenerations;

		[Required]
		[Key(5)]
		public List<RemoveSyncData> removeRegenerations;

		[Required]
		[Key(6)]
		public List<GrantSyncData> addGrants;

		[Required]
		[Key(7)]
		public List<RemoveSyncData> removeGrants;

		[Required]
		[Key(8)]
		public List<UnifiedParameterSyncData> addUnifiedParameters;

		[Required]
		[Key(9)]
		public List<RemoveSyncData> removeUnifiedParameters;
	}
}
