/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Atlas : IEnumerable<Spine.AtlasRegion>
	{
		// Fields
		private readonly List<AtlasPage> pages;
		private List<AtlasRegion> regions;
		private TextureLoader textureLoader;
	
		// Constructors
		public Atlas(TextReader reader, string dir, TextureLoader textureLoader);
		public Atlas(List<AtlasPage> pages, List<AtlasRegion> regions);
	
		// Methods
		public IEnumerator<AtlasRegion> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		private void Load(TextReader reader, string imagesDir, TextureLoader textureLoader);
		private static string ReadValue(TextReader reader);
		private static int ReadTuple(TextReader reader, string[] tuple);
		public void FlipV();
		public AtlasRegion FindRegion(string name);
		public void Dispose();
	}
}
