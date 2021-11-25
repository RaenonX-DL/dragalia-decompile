using System;

namespace Gluon
{
	[Serializable]
	public class AIScriptParam
	{
		[Serializable]
		public class Column
		{
			public AIScriptValue[] values;

			public TermsCompare.eCompare compare;
		}

		public Column[] columns;

		public string ValueString => null;

		public AIScriptValue Value => null;

		public bool IsValueString => default(bool);
	}
}
