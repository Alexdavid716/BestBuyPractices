using System;
namespace Best_Buy_Best_Practices
{
	public interface IProductRepository
	{
		public IEnumerable<Product> GetAllProducts();

		public void CreateProduct(string name, double price, int categoryID);
	}
}

