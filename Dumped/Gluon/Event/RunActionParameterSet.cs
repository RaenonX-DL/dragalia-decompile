using System.Collections.Generic;
using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RunActionParameterSet : RunActionParameterBase
	{
		[Key(0)]
		public List<RunActionParameterElement> children;

		[Key(1)]
		public List<int> falseConditionParts;

		public static bool IsValidParameterSet(RunActionParameterBase param)
		{
			return default(bool);
		}
	}
}
