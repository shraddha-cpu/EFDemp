namespace EFDemp.Models
{
    public class ProductCRUD
    {
        private readonly ApplicationDbContext _context;
        public ProductCRUD(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            var product = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
                return product;
            else
                return null;

        }
        public int AddProduct(Product prod)
        {
            _context.Products.Add(prod);
            int res = _context.SaveChanges();
            return res;

        }
        public int UpdateProduct(Product prod)
        {
            _context.Products.Update(prod);
            int res = _context.SaveChanges();
            return res;
        }
        public int DeleteProduct(int id)
        {
            int res = 0;
            var product = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            if (product != null)
            {
                _context.Products.Remove(product);
                res=_context.SaveChanges();

            }
            return res;
        }

    }
}
