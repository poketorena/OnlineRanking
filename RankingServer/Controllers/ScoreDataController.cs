using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RankingServer.Data;
using RankingServer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankingServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreDataController : ControllerBase
    {
        private readonly RankingDbContext _context;

        public ScoreDataController(RankingDbContext context)
        {
            _context = context;
        }

        // GET: api/ScoreData
        // スコアをキーに降順でソートしたScoreDataのコレクションを返す
        [HttpGet]
        public IEnumerable<ScoreData> GetScoreData()
        {
            return _context.ScoreData.OrderByDescending(x => x.Score);
        }

        // GET: api/ScoreData/5
        // 指定されたidのScoreDataを返す
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScoreData([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var scoreData = await _context.ScoreData.FindAsync(id);

            if (scoreData == null)
            {
                return NotFound();
            }

            return Ok(scoreData);
        }

        // POST: api/ScoreData
        // リクエストBodyのScoreDataをデータベースに追加する
        [HttpPost]
        public async Task<IActionResult> PostScoreData([FromBody] ScoreData scoreData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (ScoreDataExists(scoreData.Id))
            {
                return BadRequest();
            }

            _context.ScoreData.Add(scoreData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScoreData", new { id = scoreData.Id }, scoreData);
        }

        // PUT: api/ScoreData/5
        // 指定されたidのScoreDataをリクエストBodyのScoreDataで上書きする
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScoreData([FromRoute] long id, [FromBody] ScoreData scoreData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != scoreData.Id)
            {
                return BadRequest();
            }

            _context.Entry(scoreData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreDataExists(id))
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

        // DELETE: api/ScoreData/5
        // 指定されたidのScoreDataをデータベースから削除する
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScoreData([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var scoreData = await _context.ScoreData.FindAsync(id);
            if (scoreData == null)
            {
                return NotFound();
            }

            _context.ScoreData.Remove(scoreData);
            await _context.SaveChangesAsync();

            return Ok(scoreData);
        }

        // 指定したidのScoreDataがデータベースに存在するか調べる
        private bool ScoreDataExists(long id)
        {
            return _context.ScoreData.Any(e => e.Id == id);
        }
    }
}
