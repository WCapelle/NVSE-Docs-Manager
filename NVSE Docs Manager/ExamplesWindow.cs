﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NVSE_Docs_Manager
{
	public partial class ExamplesWindow : Form
	{
		public ExamplesWindow()
		{
			InitializeComponent();

			
		}

		public ExamplesWindow(ref List<Examples> list)
		{
			InitializeComponent();

			examplesList = list;

		}


		List<Examples> examplesList;








	}
}
