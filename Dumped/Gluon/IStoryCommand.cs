using System.Collections;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class IStoryCommand
	{
		public StoryScriptRuntime StoryScript
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected IEnumerator _UpdateDummy()
		{
			return null;
		}

		public virtual bool Update()
		{
			return default(bool);
		}
	}
}
