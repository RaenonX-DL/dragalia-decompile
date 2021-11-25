using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;

namespace Gluon
{
	public class SameTimeHitChecker : FastUpdateMonoBehaviour
	{
		public struct SameTimeHitData
		{
			public CharacterBase from;

			public CharacterBase to;

			public int actionId;

			public int permitId;
		}

		private List<SameTimeHitData> listSameTimeHit
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private void LateUpdate()
		{
		}

		public void Clear()
		{
		}

		public bool Check(CollisionHitAttribute hit, CharacterBase target)
		{
			return default(bool);
		}
	}
}
