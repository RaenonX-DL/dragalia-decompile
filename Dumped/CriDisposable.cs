using System;

public abstract class CriDisposable : IDisposable
{
	public Guid guid;

	public CriDisposable()
	{
	}

	public abstract void Dispose();
}
