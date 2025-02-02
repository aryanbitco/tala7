





using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using Tala7_3.Data;
using Tala7_3.Model;
using Tala7_3.View;





[Route("api/[controller]")]
[ApiController]
public class WalletTomanController : ControllerBase
{
    private readonly DataContext _context;

    public WalletTomanController(DataContext context)
    {
        _context = context;
    }




    [SwaggerOperation(Summary = "خواندن تمام کیف پول تومان")]
    // GET: api/Wallet_toman
    [HttpGet("GetWallet_All_toman")]
    public async Task<ActionResult<IEnumerable<Wallet_toman>>> GetWallet_All_toman()
    {
        return await _context.Wallet_tomans.ToListAsync();
    }




    [SwaggerOperation(Summary = "خواندن یک کیف تومان")]
    // GET: api/Wallet_toman/5
    [HttpGet("GetWallet_toman_By_Id/{id}")]
    public async Task<ActionResult<Wallet_toman>> GetWallet_toman_By_Id(int id)
    {
        var Wallet_toman = await _context.Wallet_tomans.FindAsync(id);
        if (Wallet_toman == null)
        {
            return NotFound();
        }
        return Wallet_toman;
    }




    [SwaggerOperation(Summary = "ایجاد یک کیف پول تومان")]
    // POST: api/Wallet_tomans
    [HttpPost("CreateWallet_toman")]
    public async Task<ActionResult<Wallet_toman>> CreateWallet_toman(Wallet_toman Wallet_toman)
    {

        Wallet_toman.IsDeleted = false;
        _context.Wallet_tomans.Add(Wallet_toman);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(CreateWallet_toman), new { id = Wallet_toman.Id }, Wallet_toman);
    }






    [SwaggerOperation(Summary = "ویرایش یک کیف پول تومان")]
    // PUT: api/Wallet_tomans/5
    [HttpPut("EditWallet_toman/{id}")]
    public async Task<IActionResult> EditWallet_toman(int id, Wallet_toman Wallet_toman)
    {
      

        var oldٌWallet_toman = await _context.Wallet_tomans.FindAsync(id);


        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!Wallet_tomanExists(id))
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




    //[SwaggerOperation(Summary = "ویرایش یک کیف پول تومان")]
    //// PUT: api/Wallet_tomans/5
    //[HttpPost("{id}")]
    //public async Task<IActionResult> EditWallet_toman_exist(int id, Wallet_tomanDto Wallet_tomanDto)
    //{
    //    var Wallet_toman = await _context.Wallet_tomans.FindAsync(id);
    //    Wallet_toman.Exist_toman = Wallet_tomanDto.Exist_toman;

    //    _context.Wallet_tomans.Update(Wallet_toman);
    //    try
    //    {
    //        await _context.SaveChangesAsync();
    //    }
    //    catch (DbUpdateConcurrencyException)
    //    {
    //        if (!Wallet_tomanExists(id))
    //        {
    //            return NotFound();
    //        }
    //        else
    //        {
    //            throw;
    //        }
    //    }

    //    return NoContent();
    //}


    // DELETE: api/Wallet_tomans/5



    [SwaggerOperation(Summary = "حذف یک کیف پول تومان")]
    [HttpDelete("DeleteWallet_toman/{id}")]
    public async Task<IActionResult> DeleteWallet_toman(int id)
    {
        var _wallet_toman = await _context.Wallet_tomans.FindAsync(id);
        if (_wallet_toman == null)
        {
            return NotFound();
        }
        _wallet_toman.IsDeleted = true;
        _context.Wallet_tomans.Update(_wallet_toman);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool Wallet_tomanExists(int id)
    {
        return _context.Wallet_tomans.Any(e => e.Id == id);
    }
}





