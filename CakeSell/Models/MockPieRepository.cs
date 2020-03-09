using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeSell.Models
{
	public class MockPieRepository : IPieRepository
	{
		private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();


		public IEnumerable<Pie> AllPies =>
			new List<Pie>
			{
				new Pie{PieId = 1, Name= "Strawberry Pie", Price = 15.95M, ShortDescription = "Lorem1",LongDescription = "Is just a Pie" },
				new Pie{PieId = 2, Name= "Cheese cake", Price = 18.95M, ShortDescription = "Lorem2",LongDescription = "Is just a cheese and I will not eat them" },
				new Pie{PieId = 3, Name= "Rhubarb Pie", Price = 15.95M, ShortDescription = "Lorem3", LongDescription = "This is a big problem" },
				new Pie{PieId = 4, Name= "Pumpkin Pie", Price = 12.95M, ShortDescription = "Lorem4", LongDescription = "Is very good but if you want to buy you must pay a big price also" }

			};
		public IEnumerable<Pie> PiesOfTheWeek { get; }

		public Pie GetPieById(int pieId)
		{
			return AllPies.FirstOrDefault(p => p.PieId == pieId);
		}


	}
}
