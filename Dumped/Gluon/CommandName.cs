using System;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CommandName : Attribute
	{
		public string name
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

		public CommandName(string name)
		{
		}
	}
}
