using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GirlsProfileManager.Models
{
	public class ProfileModel
	{
		[Key]
		public int Id;
		public string Name;
	}
}
