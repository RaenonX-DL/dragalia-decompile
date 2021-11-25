using System;
using System.Runtime.CompilerServices;

namespace Cute.Core
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ProjectPrefsAttr : Attribute
	{
		public string label
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

		public string tooltip
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

		public string group
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

		public ProjectPrefsAttr(string label)
		{
		}

		public ProjectPrefsAttr(string label, string tooltip)
		{
		}

		public ProjectPrefsAttr(string label, string tooltip, string group)
		{
		}
	}
}
