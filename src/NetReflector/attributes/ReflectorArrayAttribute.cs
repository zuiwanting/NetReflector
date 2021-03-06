using System;

namespace Exortech.NetReflector
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class ReflectorArrayAttribute : ReflectorPropertyAttribute
	{
		public ReflectorArrayAttribute(string name) : base(name)
		{}
	}
}