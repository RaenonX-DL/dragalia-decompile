using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterState : EventBase<CharacterState>
	{
		[Required]
		[Key(1)]
		public CharacterId characterId;

		[Key(2)]
		public Vector3 position;

		[Key(3)]
		public float rotation;

		[Key(4)]
		public CharacterId targetId;

		[Key(5)]
		public short index;

		[Key(6)]
		public byte state;

		[Required]
		[Key(7)]
		public int[] param;

		[Required]
		[Key(8)]
		public float[] paramf;

		[Key(9)]
		public bool isAwake;

		[Key(10)]
		public byte[] aiScriptContext;

		[Key(11)]
		public RunActionEvent runActionEvent;

		[Key(12)]
		public byte flags;
	}
}
