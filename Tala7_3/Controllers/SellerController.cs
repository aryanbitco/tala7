

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Tala7_3.Data;
using Tala7_3.Model.Profile;
using Tala7_3.View;





[Route("api/[controller]")]
[ApiController]
public class SellerController : ControllerBase
{
    private readonly DataContext _context;//اینجکشن به دیتا بیس

    public SellerController(DataContext context)//کانستارکتور
    {
        _context = context;
    }






    [SwaggerOperation(Summary = "خواندن تمام فروشندگان")]
    // GET: api/sellers
    [HttpGet("Get_All_Sellers")]
    public async Task<ActionResult<IEnumerable<Seller>>> Get_All_Sellers()
    {
        return await _context.Sellers.Where(x => x.IsDeleted == false).ToListAsync();
    }







    [SwaggerOperation(Summary = "خواندن یک فروشنده")]
    // GET: api/GetSeller_by_id/5
    [HttpGet("GetSeller_by_id/{id}")]
    public async Task<ActionResult<Seller>> GetSeller_by_id(int id)
    {
        var seller = await _context.Sellers.FindAsync(id);
        if (seller == null)
        {
            return NotFound();
        }
        return seller;
    }






    [SwaggerOperation(Summary = "ایجاد یک فروشنده")]
    // POST: api/CreateSeller
    [HttpPost("CreateSeller")]
    public async Task<ActionResult<Seller>> CreateSeller(Seller seller)
    {
        int maxSeller_code;
        if (_context.Sellers.Count() > 0)
        {
            maxSeller_code = _context.Sellers.Max(p => p.Seller_code);
            maxSeller_code++;
            seller.Seller_code = maxSeller_code;
        }
        else
        {
            maxSeller_code = 1000;
        }
        seller.IsDeleted=false;
        _context.Sellers.Add(seller);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(CreateSeller), new { id = seller.Id }, seller);
    }








    [SwaggerOperation(Summary = "ویرایش یک فروشنده")]
    // PUT: api/sellers/5
    [HttpPost("EditSeller_info/{id}")]
    public async Task<IActionResult> EditSeller_info(int id, SellerEditDto seller)
    {
        //if (id != seller.Id)
        //{
        //    return BadRequest();
        //}

        //_context.Entry(seller).State = EntityState.Modified;

        var _oldSeller = await _context.Sellers.FindAsync(id);
        _oldSeller.Mobile = seller.Mobile;
        _oldSeller.Tel = seller.Tel;


        _context.Sellers.Update(_oldSeller);
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SellerExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }





    [SwaggerOperation(Summary = "حذف یک فروشنده")]
    // DELETE: api/sellers/5
    [HttpPost("DeleteSeller/{id}")]
    public async Task<IActionResult> DeleteSeller(int id)
    {
        var _seller = await _context.Sellers.FindAsync(id);
        if (_seller == null)
        {
            return NotFound();
        }
        _seller.IsDeleted = true;
        _context.Sellers.Update(_seller);
        await _context.SaveChangesAsync();

        return NoContent();
    }






    private bool SellerExists(int id)
    {
        return _context.Sellers.Any(e => e.Id == id);
    }
}
