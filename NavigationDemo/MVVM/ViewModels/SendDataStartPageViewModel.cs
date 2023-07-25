using NavigationDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemo.MVVM.ViewModels
{
	public class SendDataStartPageViewModel
	{
		public SendDataStartPageModel SendDataStartPageModel { get; set; }

		public SendDataStartPageViewModel() 
		{
			SendDataStartPageModel = new SendDataStartPageModel();
		}

	}
}
