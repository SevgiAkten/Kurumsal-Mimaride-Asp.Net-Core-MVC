﻿using Abc.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Abc.Northwind.Entities.Concrete
{
	public class Product:IEntity
	{
		//Devart entity generation tools
		[Required]
		public int ProductId { get; set; }
		[Required]
		public string ProductName { get; set; }
		[Required]
		public int CategoryId { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]
		public short UnitsInStock { get; set; }
	}
}
