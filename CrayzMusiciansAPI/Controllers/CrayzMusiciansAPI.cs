using CrayzMusiciansAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CrayzMusiciansAPI.Controllers
{
    [Route("api/[controller]")] // Bu denetleyiciye "api/CrayzMusicians" URL'si ile erişilebilir.
    [ApiController] // Denetleyicinin bir API olduğunu belirtir ve otomatik model doğrulama sağlar.
    public class CrayzMusiciansController : ControllerBase
    {
        // Müzisyen listesi (sabit bir liste olarak tanımlanmış, veri katmanından geliyor)
        private static List<CrazyMusicians> CrazyMusicians = Datlist.CrazyMusicians;

        // GET: api/CrayzMusicians
        [HttpGet]
        public IActionResult GetAllMusicians()
        {
            return Ok(CrazyMusicians); // Tüm müzisyenleri HTTP 200 (OK) yanıtıyla döndürür.
        }

        // GET: api/CrayzMusicians/search?name=isim
        [HttpGet("search")]
        public IActionResult SearchMusicians([FromQuery] string name)
        {
            // İsme göre müzisyen araması yapar (büyük/küçük harf duyarsız olarak)
            var result = CrazyMusicians
                .Where(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Sonuç varsa döndürür, yoksa 404 (Not Found) yanıtı verir.
            return result.Any() ? Ok(result) : NotFound("Eşleşen müzisyen bulunamadı.");
        }

        // POST: api/CrayzMusicians
        [HttpPost]
        public IActionResult CreateMusician([FromBody] CrazyMusicians newMusician)
        {
            // ID'nin benzersiz olup olmadığını kontrol eder.
            if (CrazyMusicians.Any(m => m.Id == newMusician.Id))
                return BadRequest("Aynı ID'ye sahip bir müzisyen zaten var.");

            CrazyMusicians.Add(newMusician); // Yeni müzisyeni listeye ekler.

            // Yeni oluşturulan müzisyeni HTTP 201 (Created) yanıtıyla döndürür.
            return CreatedAtAction(nameof(GetAllMusicians), new { id = newMusician.Id }, newMusician);
        }

        // PATCH: api/CrayzMusicians/{id}
        [HttpPatch("{id}")]
        public IActionResult UpdateMusicianFeature(int id, [FromBody] string newFeature)
        {
            // Belirtilen ID'ye sahip müzisyeni arar.
            var musician = CrazyMusicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Müzisyen bulunamadı.");

            // Müzisyenin özelliğini günceller.
            musician.EnjoyProperty = newFeature;
            return NoContent(); // HTTP 204 (No Content) yanıtını döndürür.
        }

        // PUT: api/CrayzMusicians/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMusician(int id, [FromBody] CrazyMusicians updatedMusician)
        {
            // Belirtilen ID'ye sahip müzisyeni arar.
            var musician = CrazyMusicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Müzisyen bulunamadı.");

            // Müzisyenin tüm özelliklerini günceller.
            musician.Name = updatedMusician.Name;
            musician.Job = updatedMusician.Job;
            musician.EnjoyProperty = updatedMusician.EnjoyProperty;

            return NoContent(); // HTTP 204 (No Content) yanıtını döndürür.
        }

        // DELETE: api/CrayzMusicians/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMusician(int id)
        {
            // Belirtilen ID'ye sahip müzisyeni arar.
            var musician = CrazyMusicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound("Müzisyen bulunamadı.");

            CrazyMusicians.Remove(musician); // Müzisyeni listeden kaldırır.
            return NoContent(); // HTTP 204 (No Content) yanıtını döndürür.
        }
    }
}
