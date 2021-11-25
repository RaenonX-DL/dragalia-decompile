using System.Collections;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class ResistAllAbnormal
	{
		public enum SourceType
		{
			All,
			ActionParts,
			BoundaryAction,
			BerserkAbirity,
			IronWall,
			Buff,
			Init
		}

		private BitArray flags;

		public CharacterBase owner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ResistAllAbnormal(CharacterBase chara)
		{
		}

		public void Clear()
		{
		}

		public void Set(bool flag, SourceType type = SourceType.All)
		{
		}

		public bool Get(SourceType type)
		{
			return default(bool);
		}

		public bool Any()
		{
			return default(bool);
		}
	}
}
