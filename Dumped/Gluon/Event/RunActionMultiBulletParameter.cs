using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionMultiBulletParameter : RunActionParameterBase
	{
		[Key(0)]
		public uint randomSeed;

		[Key(1)]
		public List<int> appearChildTaskIds;

		[Key(2)]
		public int generateNum;

		[Key(3)]
		public List<CharacterId> listLockOnDebuff;
	}
}
