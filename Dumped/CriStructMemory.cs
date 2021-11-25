using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class CriStructMemory<Type> : IDisposable
{
	private GCHandle gch;

	public byte[] bytes
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IntPtr ptr => default(IntPtr);

	public CriStructMemory()
	{
	}

	public CriStructMemory(int num)
	{
	}

	public void Dispose()
	{
	}
}
