using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class LocalizeScriptableObject : ScriptableObject
	{
		public string[] texts;

		public static Func<string, string[]> LoadForEditorEvent
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

		public static string[] Load(string region)
		{
			return null;
		}
	}
}
