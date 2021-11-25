using System.Diagnostics;

namespace Coneshell
{
	public static class Dynamic
	{
		[Conditional("UNITY_EDITOR_WIN")]
		public static void UnloadLibrary()
		{
		}
	}
}
