using System.Collections;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class NPFInitializer : SingletonMonoBehaviour<NPFInitializer>
	{
		private NPFEventHandlerImpl pNPFEventhandler;

		public bool isInitialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void Init()
		{
		}

		public IEnumerator WaitInitCoroutine()
		{
			return null;
		}
	}
}
