﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class CreditCard:IPurchase
	{
		public bool Purchase()
		{
			return true;
		}
	}
}
