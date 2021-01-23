/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class Randomizer : Random
	{
		// Fields
		public const string DefaultStringChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789_";
		private const int DefaultStringLength = 25;
		private static Random _seedGenerator;
		private static int _initialSeed;
		private static Dictionary<MemberInfo, Randomizer> Randomizers;
	
		// Properties
		public static int InitialSeed { set; }
	
		// Constructors
		static Randomizer();
		public Randomizer(int seed);
	
		// Methods
		public static Randomizer CreateRandomizer();
	}
}
