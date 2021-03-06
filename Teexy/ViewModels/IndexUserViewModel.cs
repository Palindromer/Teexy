﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.ViewModels
{
	public class IndexUserViewModel
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public string AvatarUrl { get; set; }
	}
}
