using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class AbnormalStatusFreeze : AbnormalStatusBase
	{
		private int attackCount;

		public override bool Update()
		{
			return default(bool);
		}

		public override void Exit()
		{
		}

		public override void PlayEffect([Optional] GameObject node)
		{
		}

		public override bool ReleaseFreezeOnCollided()
		{
			return default(bool);
		}
	}
}
