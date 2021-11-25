using System;

namespace Gluon
{
	[Serializable]
	public class AIScriptContainer
	{
		public AIScriptDef.Command _command;

		public AIScriptParam[] _params;

		public int _jumpStep;

		[NonSerialized]
		public const int _outStep = 1;
	}
}
