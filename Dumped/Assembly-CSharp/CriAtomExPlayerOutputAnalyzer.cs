/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[Obsolete]
public class CriAtomExPlayerOutputAnalyzer : CriAtomExOutputAnalyzer
{
	// Nested types
	public enum Type
	{
		LevelMeter = 0,
		SpectrumAnalyzer = 1,
		PcmCapture = 2
	}

	public struct Config
	{
		// Fields
		public int num_spectrum_analyzer_bands;
		public int num_stored_output_data;

		// Constructors
		public Config(int num_spectrum_analyzer_bands = 8, int num_stored_output_data = 4096);
	}

	// Constructors
	public CriAtomExPlayerOutputAnalyzer(Type[] types, Config[] configs = null);
}

