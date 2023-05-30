﻿using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace LaLlamaDelBosque.Models
{

	public class LotteryModel
	{
		public List<Lottery> Lotteries { get; set; } = new List<Lottery>();
	}

	public class Lottery
	{
		public string Name { get; set; } = "";
		public TimeSpan Hour { get; set; }
	}

	public class Number
	{
		public int? Id { get; set; }
		public int Value { get; set; }
		public double Amount { get; set; }
		public double Busted { get; set; }
	}

	public class Numbers
	{

		[Required(ErrorMessage = "El campo es requerido.")]
		public string? Value { get; set; } = null;
		[Required(ErrorMessage = "El campo es requerido.")]
		public double? Amount { get; set; } = null;
		[Required(ErrorMessage = "El campo es requerido.")]
		public double Busted { get; set; }
	}


	public class PaperModel
	{
		public List<Paper> Papers { get; set; } = new List<Paper>();
	}

	public class Paper
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "El campo es requerido.")]
		public string Lottery { get; set; } = "";
		[Required(ErrorMessage = "El campo es requerido.")]
		public DateTime Date { get; set; }
		public TimeSpan Hour { get; set; }
		public List<Number> Numbers { get; set; } = new List<Number>();
	}
}

