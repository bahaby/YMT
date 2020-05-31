using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Bridge
{
	public abstract class ComponentAbstraction
	{
		public ComponentImplementor _componentBuilder;
		public abstract void ComponentBuilder();
	}
}
