/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.IO
{
	public static class FileUtil
	{
		// Methods
		public static void Write(string path, byte[] bytes);
		public static byte[] Read(string path);
		private static byte[] GetData(byte[] src);
		private static bool IsEqual(byte[] l, byte[] r);
		private static string GetOldPath(string path);
	}
}
