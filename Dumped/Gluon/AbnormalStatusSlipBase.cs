using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class AbnormalStatusSlipBase : AbnormalStatusBase
	{
		public override bool Update()
		{
			return default(bool);
		}

		protected override void OnEventInterval()
		{
		}

		public override void PlayEffect([Optional] GameObject node)
		{
		}
	}
}
