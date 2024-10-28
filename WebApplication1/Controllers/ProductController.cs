using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // 示例数据
        private static List<string> products = new List<string> { "Laptops", "Phone", "Tablet" };

        // GET: api/product
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            GetExcel gt = new GetExcel();
            products.Add(gt.GetValue());
            Console.WriteLine(products[3]);
            return products;
        }

        // GET: api/product/1
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= products.Count)
                return NotFound();

            return products[id];
        }

        // POST: api/product
        [HttpPost]
        public ActionResult Post([FromBody] string product)
        {
            products.Add(product);
            return Ok();
        }

        // DELETE: api/product/1
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= products.Count)
                return NotFound();

            products.RemoveAt(id);
            return Ok();
        }
    }
}
