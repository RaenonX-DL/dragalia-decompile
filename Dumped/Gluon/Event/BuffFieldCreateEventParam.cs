using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BuffFieldCreateEventParam : BuffFieldEventParamBase
	{
		[Required]
		[Key(0)]
		public long actionPartsResourceId;

		[Required]
		[Key(1)]
		public uint hitAttrLabelCrc32;

		[Required]
		[Key(2)]
		public Vector3 position;

		[Required]
		[Key(3)]
		public Quaternion rotation;

		[Required]
		[Key(4)]
		public int actionId;

		[Required]
		[Key(5)]
		public int skillId;

		[Required]
		[Key(6)]
		public int actionProductId;

		[Required]
		[Key(7)]
		public float skillDamageUpBuffRate;

		[Required]
		[Key(8)]
		public int warpRoomGroupId;

		[Required]
		[Key(9)]
		public bool isHostRequest;

		[Key(10)]
		public int tensionLevel;

		[Key(11)]
		public int inspirationLevel;
	}
}
